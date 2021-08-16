using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Entities
{
    public class WeightProduct : Product
    {
        [Required, DataType(DataType.Currency)]
        public decimal PricePerKilo { get; set; }
        public double? KiloInStock { get; set; }

        public static WeightProduct Create(int productId, int categoryId, int manufacturerId, string name, decimal pricePerKilo = 0, int? kiloInStock = null)
        {
            var product = new WeightProduct
            {
                Id = productId,
                CategoryId = categoryId,
                ManufacturerId = manufacturerId,
                Name = name,
                PricePerKilo = pricePerKilo,
                KiloInStock = kiloInStock
            };
            return product;
        }
    }
}
