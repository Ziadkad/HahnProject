﻿using System.Linq.Expressions;

namespace Backend.Repositories.Interfaces;

public interface IGenericRepository <T> where T : class
{
    Task<List<T>> GetAllAsNoTracking(Expression<Func<T, bool>>? filter = null);
    Task<T?> GetAsNoTracking(Expression<Func<T, bool>>? filter = null);
    Task<List<T>> GetAllAsTracking(Expression<Func<T, bool>>? filter = null);
    Task<T?> GetAsTracking(Expression<Func<T, bool>>? filter = null);
    Task CreateRangeAsync(ICollection<T> entities);
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task RemoveAsync(T entity);
    Task<bool> SaveChangesAsync();
}