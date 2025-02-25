using MediatR;

namespace PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024BCSv20250131.Command
{
    public class CapacidadDemandadaYRAPEn2024BCSv20250131Command : IRequest<CapacidadDemandadaYRAPEn2024BCSv20250131Response>
    {
        public PruebaTecnica.Dominio.Entidades.CapacidadDemandadaYRAPEn2024BCSv20250131[] CapacidadDemandadaYRAPEn2024BCSv20250131s { get; set; }
    }
}
