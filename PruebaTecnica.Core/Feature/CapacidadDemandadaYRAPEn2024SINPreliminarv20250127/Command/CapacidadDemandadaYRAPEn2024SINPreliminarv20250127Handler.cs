using MediatR;
using PruebaTecnica.Persistencia.Repositorio;

namespace PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024SINPreliminarv20250127.Command
{
    public class CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Handler : IRequestHandler<CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Command, CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Response>
    {
        private IAsyncRepositorio _asyncRepositorio;
        public CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Handler(IAsyncRepositorio asyncRepositorio)
        {
            _asyncRepositorio = asyncRepositorio;
        }
        public async Task<CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Response> Handle(CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Command request, CancellationToken cancellationToken)
        {
            await _asyncRepositorio.AddRangeAsync(request.CapacidadDemandadaYRAPEn2024SINPreliminarv20250127s);

            var res = new CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Response();

            return res;
        }
    }
}
