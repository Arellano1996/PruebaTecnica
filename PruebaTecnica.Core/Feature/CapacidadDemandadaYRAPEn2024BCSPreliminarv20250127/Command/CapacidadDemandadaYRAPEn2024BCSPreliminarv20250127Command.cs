using MediatR;

namespace PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127.Command
{
    public class CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127Command : IRequest<CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127Response>
    {
        public PruebaTecnica.Dominio.Entidades.CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127[] CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127s { get; set; }
    }
}
