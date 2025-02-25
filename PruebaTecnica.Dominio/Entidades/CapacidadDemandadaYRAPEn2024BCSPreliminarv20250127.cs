using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Dominio.Entidades
{
    public class CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string ZonaDePotencia { get; set; }
        public required string Participante { get; set; }
        public required string SubCuentaDelParticipante { get; set; }
        public double CapacidadDemandadaMW { get; set; }
        public double RequisitoAnualDePotenciaMWAnio { get; set; }
        public double ValorDelRequisitoAnualDePotenciaEficienteMWAnio { get; set; }
    }
}
