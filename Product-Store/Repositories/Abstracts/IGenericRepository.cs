﻿using ProductDB.Entities.Abstracts;

namespace Product_Store.Repositories.Abstracts
{
    public interface IGenericRepository<T>where T:BaseEntity,new()
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();

    }
}
