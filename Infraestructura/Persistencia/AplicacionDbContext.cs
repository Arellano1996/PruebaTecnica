using Microsoft.EntityFrameworkCore;
using Presentacion.Dominio.Entidades;

namespace pruebaTecnica.Infraestructura.Persistencia
{
    public class AplicacionDbContext : DbContext
    {
        public AplicacionDbContext(DbContextOptions options) : base( options )
        {
            
        }

        public DbSet<CapacidadDemandadaYRAPEn2024SINv20250131> CapacidadDemandadaYRAPEn2024SINv20250131 { get; set; }
        public DbSet<CapacidadDemandadaYRAPEn2024SINPreliminarv20250127> CapacidadDemandadaYRAPEn2024SINPreliminarv20250127 { get; set; }
        public DbSet<CapacidadDemandadaYRAPEn2024BCSv20250131> CapacidadDemandadaYRAPEn2024BCSv20250131 { get; set; }
        public DbSet<CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127> CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127 { get; set; }
        public DbSet<CapacidadDemandadaYRAPEn2024BCAv20250131> CapacidadDemandadaYRAPEn2024BCAv20250131 { get; set; }
        public DbSet<CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127> CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127 { get; set; }
    }
}
