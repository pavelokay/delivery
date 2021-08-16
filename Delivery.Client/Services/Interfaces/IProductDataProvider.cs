using Delivery.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Client.Services.Interfaces
{
    public interface IProductDataProvider
    {
        Task<IEnumerable<ProductModel>> GetProducts();

        Task<string> CreateProduct(ProductModel product);
        Task<string> UpdateProduct(ProductModel product);
        Task<string> DeleteProduct(int productId);
    }
}
