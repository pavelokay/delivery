using Delivery.Core.Entities;
using Delivery.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductListAsync();
        Task<Product> GetProductBySlug(string slug);
        Task<IEnumerable<Product>> GetProductByNameAsync(string productName);
        Task<Product> GetProductByIdWithCategoryAsync(int productId);
        Task<IEnumerable<Product>> GetProductByCategoryAsync(int categoryId);
    }
}
