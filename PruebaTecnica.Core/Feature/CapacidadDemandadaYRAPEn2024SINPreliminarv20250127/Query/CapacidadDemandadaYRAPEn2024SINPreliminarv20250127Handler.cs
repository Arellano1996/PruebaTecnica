using MediatR;
using PruebaTecnica.Persistencia.Repositorio;

namespace PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024SINPreliminarv20250127.Query
{
    public class CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Handler : IRequestHandler<CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Query, CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Response>
    {
        private IAsyncRepositorio _asyncRepositorio;

        public CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Handler(IAsyncRepositorio asyncRepositorio)
        {
            _asyncRepositorio = asyncRepositorio;
        }

        public async Task<CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Response> Handle(CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Query request, CancellationToken cancellationToken)
        {
            var resultado = await _asyncRepositorio.GetAllAsync<PruebaTecnica.Dominio.Entidades.CapacidadDemandadaYRAPEn2024SINPreliminarv20250127>();
            
            var res = new CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Response();

            res.resultado = resultado.ToList();

            return res;
        }
    }
}
