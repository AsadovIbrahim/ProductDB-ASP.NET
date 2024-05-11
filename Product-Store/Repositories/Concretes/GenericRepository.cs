using Microsoft.EntityFrameworkCore;
using Product_Store.Repositories.Abstracts;
using ProductDB.Contexts;
using ProductDB.Entities.Abstracts;

namespace Product_Store.Repositories.Concretes
{
    public class GenericRepository<T>:IGenericRepository<T>where T:BaseEntity,new()
    {
        protected readonly ProductDbContext _context;

        public GenericRepository(ProductDbContext context)
        {
            _context=context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity=await _context.Set<T>().FirstOrDefaultAsync(p => p.Id == id);
            _context.Set<T>().Remove(entity!);
            await _context.SaveChangesAsync();

        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
