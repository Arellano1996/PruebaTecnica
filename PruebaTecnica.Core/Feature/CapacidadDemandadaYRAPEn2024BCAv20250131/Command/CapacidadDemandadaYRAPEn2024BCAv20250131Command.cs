using MediatR;

namespace PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024BCAv20250131.Command
{
    public class CapacidadDemandadaYRAPEn2024BCAv20250131Command : IRequest<CapacidadDemandadaYRAPEn2024BCAv20250131Response>
    {
        public PruebaTecnica.Dominio.Entidades.CapacidadDemandadaYRAPEn2024BCAv20250131[] CapacidadDemandadaYRAPEn2024BCAv20250131s { get; set; }
    }
}
