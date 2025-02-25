using MediatR;
using PruebaTecnica.Persistencia.Repositorio;

namespace PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024BCAv20250131.Query
{
    public class CapacidadDemandadaYRAPEn2024BCAv20250131Handler : IRequestHandler<CapacidadDemandadaYRAPEn2024BCAv20250131Query, CapacidadDemandadaYRAPEn2024BCAv20250131Response>
    {
        private IAsyncRepositorio _asyncRepositorio;

        public CapacidadDemandadaYRAPEn2024BCAv20250131Handler(IAsyncRepositorio asyncRepositorio)
        {
            _asyncRepositorio = asyncRepositorio;
        }

        public async Task<CapacidadDemandadaYRAPEn2024BCAv20250131Response> Handle(CapacidadDemandadaYRAPEn2024BCAv20250131Query request, CancellationToken cancellationToken)
        {
            var respuesta = await _asyncRepositorio.GetAllAsync<PruebaTecnica.Dominio.Entidades.CapacidadDemandadaYRAPEn2024BCAv20250131>();

            var res = new CapacidadDemandadaYRAPEn2024BCAv20250131Response();

            res.respuesta = respuesta.ToList();

            return res;
        }
    }
}
