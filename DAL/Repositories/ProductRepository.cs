using System;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly TestDBContext _dbContext;
        public ProductRepository(TestDBContext context) : base(context)
        {
            _dbContext = context;
        }

        async Task<List<Product>> IProductRepository.GetProductWithAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }
    }
}

