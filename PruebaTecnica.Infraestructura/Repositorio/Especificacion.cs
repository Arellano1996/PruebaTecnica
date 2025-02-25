using System.Linq.Expressions;

namespace PruebaTecnica.Persistencia.Repositorio
{
   
    public class Especificacion<T> : IEspecificacion<T>
        {
            public Especificacion()
            {
            }
            public Especificacion(Expression<Func<T, bool>> criteria)
            {
                Criteria = criteria;
            }
            public Expression<Func<T, bool>> Criteria { get; }
            public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();
            public Expression<Func<T, object>> OrderBy { get; private set; }
            public Expression<Func<T, object>> OrderByDescending { get; private set; }
            public int? Page { get; private set; }
            public int? PageSize { get; private set; }
            protected void AddInclude(Expression<Func<T, object>> includeExpression)
            {
                Includes.Add(includeExpression);
            }
            protected void AddOrderBy(Expression<Func<T, object>> orderByExpression)
            {
                OrderBy = orderByExpression;
            }
            protected void AddOrderByDescending(Expression<Func<T, object>> orderByDescExpression)
            {
                OrderByDescending = orderByDescExpression;
            }
            protected void AddPagination(int page, int pageSize)
            {
                Page = page;
                PageSize = pageSize;
            }
        }
    
}
