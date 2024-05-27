using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IProductCategoryService
    {
        public Task<IList<ProductCategory>> GetProductCategorys();
        public Task<bool> CreateProductCategory(ProductCategory productCategory);
        public Task<bool> UpdateProductCategory(ProductCategory productCategory);
        public Task<bool> DeleteProductCategory(ProductCategory productCategory);
        public Task<ProductCategory> GetProductCategory(int id);
    }
}
