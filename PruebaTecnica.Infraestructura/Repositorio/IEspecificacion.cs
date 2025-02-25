using System.Linq.Expressions;

namespace PruebaTecnica.Persistencia.Repositorio
{
    public interface IEspecificacion<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        int? Page { get; }
        int? PageSize { get; }
    }
}
