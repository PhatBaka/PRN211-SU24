using BusinessObjects.Models;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Impls
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _productRepository;

        public ProductService(IGenericRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IList<Product>> GetProducts()
        {
            try
            {
                var product = await _productRepository.GetAllAsync();
                return product.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving prodct: {ex.Message}", ex);
            }
        }

        public async Task<bool> CreateProduct(Product product)
        {
            try
            {
                return await _productRepository.InsertAsync(product);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating prodct: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            try
            {
                return await _productRepository.UpdateByIdAsync(product, product.ProductId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating product: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteProduct(Product product)
        {
            try
            {
                return await _productRepository.DeleteAsync(product);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting product: {ex.Message}", ex);
            }
        }

        public async Task<Product> GetProduct(int id)
        {
            try
            {
                return await _productRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving prodct by ID: {ex.Message}", ex);
            }
        }
    }
}

