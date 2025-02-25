using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PruebaTecnica.Dominio.Entidades;

namespace PruebaTecnica.Persistencia
{
    public class AppDbContext : DbContext
    {
        private IConfiguration _configuration { get; set; }
        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cadenaConexion = _configuration.GetConnectionString("ConexionPostgres");
            optionsBuilder.UseNpgsql( cadenaConexion );
        }

        public DbSet<CapacidadDemandadaYRAPEn2024SINv20250131> CapacidadDemandadaYRAPEn2024SINv20250131 { get; set; }
        public DbSet<CapacidadDemandadaYRAPEn2024SINPreliminarv20250127> CapacidadDemandadaYRAPEn2024SINPreliminarv20250127 { get; set; }
        public DbSet<CapacidadDemandadaYRAPEn2024BCSv20250131> CapacidadDemandadaYRAPEn2024BCSv20250131 { get; set; }
        public DbSet<CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127> CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127 { get; set; }
        public DbSet<CapacidadDemandadaYRAPEn2024BCAv20250131> CapacidadDemandadaYRAPEn2024BCAv20250131 { get; set; }
        public DbSet<CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127> CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127 { get; set; }
    }
}
