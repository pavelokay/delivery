using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Entities
{
    public class UnitProduct : Product
    {
        [Required, DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public double Weight { get; set; }
        public int QuantityInPackage { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }

        public static UnitProduct Create(int productId, int categoryId, int manufacturerId, string name, double weight, int quantityInPackage, UnitOfMeasurement unitOfMeasurement, decimal unitPrice = 0, int? unitsInStock = null)
        {
            var product = new UnitProduct
            {
                Id = productId,
                CategoryId = categoryId,
                ManufacturerId = manufacturerId,
                Name = name,
                UnitPrice = unitPrice,
                UnitsInStock = unitsInStock,
                Weight = weight,
                QuantityInPackage = quantityInPackage,
                UnitOfMeasurement = unitOfMeasurement
            };
            return product;
        }
    }

    public enum UnitOfMeasurement : byte
    {
        [Description("UN")]
        Unity = 1,

        [Description("KG")]
        Kilogram = 2,

        [Description("L")]
        Liter = 3
    }
}
