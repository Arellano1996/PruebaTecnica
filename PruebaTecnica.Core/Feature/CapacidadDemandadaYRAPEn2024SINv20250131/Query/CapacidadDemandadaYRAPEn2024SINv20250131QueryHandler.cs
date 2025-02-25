using MediatR;
using PruebaTecnica.Persistencia.Repositorio;

namespace PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024SINv20250131.Query
{
    public class CapacidadDemandadaYRAPEn2024SINv20250131QueryHandler : IRequestHandler<CapacidadDemandadaYRAPEn2024SINv20250131Query, CapacidadDemandadaYRAPEn2024SINv20250131QueryResponse>
    {
        private IAsyncRepositorio _asyncRepositorio;

        public CapacidadDemandadaYRAPEn2024SINv20250131QueryHandler(IAsyncRepositorio asyncRepositorio)
        {
            _asyncRepositorio = asyncRepositorio;
        }

        public async Task<CapacidadDemandadaYRAPEn2024SINv20250131QueryResponse> Handle(CapacidadDemandadaYRAPEn2024SINv20250131Query request, CancellationToken cancellationToken)
        {
            var resultado = await _asyncRepositorio.GetAllAsync<PruebaTecnica.Dominio.Entidades.CapacidadDemandadaYRAPEn2024SINv20250131>();
            
            var res = new CapacidadDemandadaYRAPEn2024SINv20250131QueryResponse();
            
            res.resultado = resultado.ToList();

            return res;
        }
    }
}
