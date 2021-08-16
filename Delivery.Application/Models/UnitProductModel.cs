using Delivery.Application.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Models
{
    public class UnitProductModel : ProductModel
    {
        public decimal? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public double Weight { get; set; }
        public int QuantityInPackage { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
    }

    public enum UnitOfMeasurement : byte
    {
        Unity = 1,
        Kilogram = 2,
        Liter = 3
    }
}
