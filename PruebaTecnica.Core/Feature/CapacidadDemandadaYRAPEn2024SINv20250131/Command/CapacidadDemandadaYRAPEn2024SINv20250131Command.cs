using MediatR;

namespace PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024SINv20250131.Command
{
    public class CapacidadDemandadaYRAPEn2024SINv20250131Command: IRequest<CapacidadDemandadaYRAPEn2024SINv20250131Response>
    {
        public PruebaTecnica.Dominio.Entidades.CapacidadDemandadaYRAPEn2024SINv20250131[] CapacidadDemandadaYRAPEn2024SINv20250131s { get; set; }
    }
}
