using MediatR;

namespace PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024SINPreliminarv20250127.Command
{
    public class CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Command : IRequest<CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Response>
    {
        public PruebaTecnica.Dominio.Entidades.CapacidadDemandadaYRAPEn2024SINPreliminarv20250127[] CapacidadDemandadaYRAPEn2024SINPreliminarv20250127s { get; set; }
    }
}
