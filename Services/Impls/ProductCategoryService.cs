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
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IGenericRepository<ProductCategory> _productCategoryRepository;

        public ProductCategoryService(IGenericRepository<ProductCategory> productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public async Task<IList<ProductCategory>> GetProductCategorys()
        {
            try
            {
                var productCategory = await _productCategoryRepository.GetAllAsync();
                return productCategory.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving product category: {ex.Message}", ex);
            }
        }

        public async Task<bool> CreateProductCategory(ProductCategory productCategory)
        {
            try
            {
                return await _productCategoryRepository.InsertAsync(productCategory);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating product category: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateProductCategory(ProductCategory productCategory)
        {
            try
            {
                return await _productCategoryRepository.UpdateByIdAsync(productCategory, productCategory.CategoryId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating product category: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteProductCategory(ProductCategory productCategory)
        {
            try
            {
                return await _productCategoryRepository.DeleteAsync(productCategory);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting product category: {ex.Message}", ex);
            }
        }

        public async Task<ProductCategory> GetProductCategory(int id)
        {
            try
            {
                return await _productCategoryRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving prouct category by ID: {ex.Message}", ex);
            }
        }
    }
}

