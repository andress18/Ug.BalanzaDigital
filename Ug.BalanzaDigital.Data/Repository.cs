using Microsoft.EntityFrameworkCore;
using Ug.BalanzaDigital.Contracts.Repository;
using Ug.BalanzaDigital.Data.DbContexts;

namespace Ug.BalanzaDigital.Data;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly BalanzaDigitalContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(BalanzaDigitalContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}