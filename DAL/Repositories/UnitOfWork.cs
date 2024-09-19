using System;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
	public class UnitOfWork: IUnitOfWork
    {
        private readonly TestDBContext _dbContext;
        private IProductRepository? _productRepository;

        public UnitOfWork(TestDBContext context)
		{
            _dbContext = context;
        }


        public IProductRepository Products => _productRepository ??= new ProductRepository(_dbContext);

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}

