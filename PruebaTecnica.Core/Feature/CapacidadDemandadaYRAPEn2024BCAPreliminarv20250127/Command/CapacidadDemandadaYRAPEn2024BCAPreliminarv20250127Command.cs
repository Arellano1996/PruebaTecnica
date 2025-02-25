using MediatR;

namespace PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127.Command
{
    public class CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127Command : IRequest<CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127Response>
    {
        public PruebaTecnica.Dominio.Entidades.CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127[] CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127s { get; set; }
    }
}
