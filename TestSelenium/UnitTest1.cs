using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024SINv20250131.Command;
using PruebaTecnica.Persistencia;
using PruebaTecnica.Persistencia.Repositorio;
using TestSelenium.Servicios;

namespace TestSelenium
{
    public class Tests()
    {
        private IServiceProvider _serviceProvider;
        private IConfiguration _configuration;
        private AppDbContext _dbContext;

        private GuardarInformacionPostgres _guardarInformacionPostgres;
        private IMediator _mediator;
        private IAsyncRepositorio _asyncRepositorio;

        [SetUp]
        public void Setup()
        {
            var services = new ServiceCollection();

            var solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            var path = Path.Combine(solutionDirectory, "Presentacion");

            // Cargar la configuración desde el archivo appsettings.json (u otra fuente)
            var builder = new ConfigurationBuilder()
                .SetBasePath(path)  // Si el archivo está en el directorio actual
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);  // Ajusta según tu archivo de configuración

            _configuration = builder.Build();

            // Asegúrate de registrar IConfiguration antes de AppDbContext
            services.AddSingleton<IConfiguration>(_configuration);  // Si tienes acceso a Configuration

            // Registrar AppDbContext
            services.AddDbContext<AppDbContext>(
                options => options.UseNpgsql(_configuration.GetConnectionString("ConexionPostgres"))
            );

            //Registrar servicio para hacer el guardado de información
            services.AddSingleton<GuardarInformacionPostgres>();

            // Registrar el repositorio
            services.AddScoped<IAsyncRepositorio, AsyncRepositorio>();

            // Registro correcto de MediatR
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CapacidadDemandadaYRAPEn2024SINv20250131Handler).Assembly));

            // Construir el service provider después de registrar todo
            _serviceProvider = services.BuildServiceProvider();

            // Obtener servicios
            _mediator = _serviceProvider.GetRequiredService<IMediator>();
            _dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
            _guardarInformacionPostgres = _serviceProvider.GetRequiredService<GuardarInformacionPostgres>();

        }

        [Test]
        public async Task Test1()
        {
            IWebDriver driver = new ChromeDriver();
            try
            {
                driver.Navigate().GoToUrl("https://www.cenace.gob.mx/Paginas/SIM/CapacidadDemandadaRAP.aspx");

                IReadOnlyCollection<IWebElement> hrefs = driver.FindElements(By.XPath("//a[contains(@href, '.xlsx')]"));

                foreach (var link in hrefs)
                {
                    //Obtenemos el url del elemento a
                    string url = link.GetAttribute("href");
                    //Obtenemos el nombre del archivo para saber en qué tabla debemos guardar la información
                    string nombreArchivo = Path.GetFileName(new Uri(url).LocalPath);
                    //Pasamos la información del archivo descargado a base64
                    string archivoBase64 = await DescargarArchivos.DescargarArchivoComoBase64(url);
                    //Convertirmos el archivo base64 en una tabla
                    var tabla = LeerExcel.LeerExcelDesdeBase64(archivoBase64);
                    //Guardamos la informacion en Postgres
                    await _guardarInformacionPostgres.GuardarDatosEnTablaCorrecta(tabla, nombreArchivo);
                }
            }
            finally
            {
                // Cerramos el navegador incluso si ocurre una excepción
                driver.Quit();
            }
        }

        [TearDown]
        public void TearDown()
        {
            _dbContext.Dispose();
            if (_serviceProvider is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }

    }
}