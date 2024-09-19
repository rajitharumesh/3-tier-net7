using System;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repositories
{
	public interface IProductRepository:IRepository<Product>
	{
        Task<List<Product>> GetProductWithAsync();
    }
}

