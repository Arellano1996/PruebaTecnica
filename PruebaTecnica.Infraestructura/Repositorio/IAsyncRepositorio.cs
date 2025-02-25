namespace PruebaTecnica.Persistencia.Repositorio
{
    public interface IAsyncRepositorio
    {
        Task<T> GetAsync<T>(object id) where T : class;
        Task<IEnumerable<T>> GetAllAsync<T>() where T : class;
        Task<IEnumerable<T>> FindAsync<T>(IEspecificacion<T> specification) where T : class;
        Task<IEnumerable<T>> FindAsyncAsNoTracking<T>(IEspecificacion<T> specification) where T : class;
        Task<int> CountAsync<T>(IEspecificacion<T> specification) where T : class;
        Task<T> AddAsync<T>(T entity) where T : class;
        Task<T[]> AddRangeAsync<T>(T[] entity) where T : class;
        Task UpdateAsync<T>(T entity) where T : class;
        Task UpdateEntityNotTrackedAsync<T>(T entity) where T : class;
        Task DeleteAsync<T>(T entity) where T : class;
        Task<IReadOnlyList<T>> GetPagedReponseAsync<T>(int page, int size) where T : class;
    }
}
