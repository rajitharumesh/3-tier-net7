﻿using System;
namespace DAL.Interfaces
{
	public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task<T?> GetByIdAsync(int id);
        Task<List<T?>> GetAllAsync(bool tracked = true);
        Task UpdateAsync(T entity);
        Task DeleteByIdAsync(int id);
        Task SaveAsync();
    }
}

