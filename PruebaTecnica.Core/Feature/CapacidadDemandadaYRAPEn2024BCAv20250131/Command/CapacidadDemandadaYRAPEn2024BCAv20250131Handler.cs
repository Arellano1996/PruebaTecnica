using MediatR;
using PruebaTecnica.Persistencia.Repositorio;

namespace PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024BCAv20250131.Command
{
    class CapacidadDemandadaYRAPEn2024BCAv20250131Handler : IRequestHandler<CapacidadDemandadaYRAPEn2024BCAv20250131Command, CapacidadDemandadaYRAPEn2024BCAv20250131Response>
    {
        private IAsyncRepositorio _asyncRepositorio;
        public CapacidadDemandadaYRAPEn2024BCAv20250131Handler(IAsyncRepositorio asyncRepositorio)
        {
            _asyncRepositorio = asyncRepositorio;
        }
        public async Task<CapacidadDemandadaYRAPEn2024BCAv20250131Response> Handle(CapacidadDemandadaYRAPEn2024BCAv20250131Command request, CancellationToken cancellationToken)
        {
            await _asyncRepositorio.AddRangeAsync(request.CapacidadDemandadaYRAPEn2024BCAv20250131s);

            var res = new CapacidadDemandadaYRAPEn2024BCAv20250131Response();

            return res;
        }
    }
}
