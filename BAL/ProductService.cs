using System;
using DAL.Interfaces;
using DAL.Models;

namespace BAL
{
	public class ProductService
	{
		private readonly IRepository<Product> _productRepository;
		public ProductService(IRepository<Product> productRepository)
		{
			_productRepository = productRepository;

        }

        public async Task AddProductAsync(Product newProduct)
        {
            await _productRepository.AddAsync(newProduct);
            await _productRepository.SaveAsync();
        }

        public async Task UpdateProductAsync(Product updatedProduct)
        {
            await _productRepository.UpdateAsync(updatedProduct);
            await _productRepository.SaveAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteByIdAsync(id);
            await _productRepository.SaveAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task<List<Product?>> GetAllAsync()
        {
            return await _productRepository.GetAllAsync();
        }
    }
}

