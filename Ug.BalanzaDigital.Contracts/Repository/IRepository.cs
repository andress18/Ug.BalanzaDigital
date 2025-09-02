namespace Ug.BalanzaDigital.Contracts.Repository;

public interface IRepository<T>
where T : class
{
    // methods CRUD for repository
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
}