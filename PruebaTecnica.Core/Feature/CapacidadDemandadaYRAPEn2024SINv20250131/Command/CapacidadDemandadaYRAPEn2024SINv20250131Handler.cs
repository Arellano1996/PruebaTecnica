using MediatR;
using PruebaTecnica.Persistencia.Repositorio;

namespace PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024SINv20250131.Command
{
    public class CapacidadDemandadaYRAPEn2024SINv20250131Handler : IRequestHandler<CapacidadDemandadaYRAPEn2024SINv20250131Command, CapacidadDemandadaYRAPEn2024SINv20250131Response>
    {
        private IAsyncRepositorio _asyncRepositorio;
        public CapacidadDemandadaYRAPEn2024SINv20250131Handler(IAsyncRepositorio asyncRepositorio)
        {
            _asyncRepositorio = asyncRepositorio;
        }
        public async Task<CapacidadDemandadaYRAPEn2024SINv20250131Response> Handle(CapacidadDemandadaYRAPEn2024SINv20250131Command request, CancellationToken cancellationToken)
        {
            await _asyncRepositorio.AddRangeAsync(request.CapacidadDemandadaYRAPEn2024SINv20250131s);

            var res = new CapacidadDemandadaYRAPEn2024SINv20250131Response();

            return res;
        }
    }
}
