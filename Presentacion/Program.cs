using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Core;
using PruebaTecnica.Persistencia;
using PruebaTecnica.Persistencia.Repositorio;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        var cadenaConexion = builder.Configuration.GetConnectionString("ConexionPostgres");

        builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(cadenaConexion));

        // Registrar IAsyncRepositorio
        builder.Services.AddScoped<IAsyncRepositorio, AsyncRepositorio>();

        // Registrar MediatR
        // Esto le dice a MediatR que busque los handlers en el ensamblaje de PruebaTecnica.Core
        builder.Services.AddMediatR(configuratio =>
        {
            configuratio.RegisterServicesFromAssembly(typeof(AssemblyReference).Assembly);
        });

        // Configuración de CORS
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("PermitirAngular",
                policy =>
                {
                    policy.WithOrigins("http://localhost:4200") // Aquí es donde se encuentra tu aplicación Angular (ajústalo si está en otro puerto o dominio)
                          //.AllowAnyMethod()
                          .WithMethods("GET")
                          .AllowAnyHeader();
                });
        });

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        // Aplicar CORS
        app.UseCors("PermitirAngular");

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}