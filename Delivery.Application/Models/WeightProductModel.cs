using Delivery.Application.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Models
{
    public class WeightProductModel : ProductModel
    {
        public decimal? PricePerKilo { get; set; }
        public double? KiloInStock { get; set; }
    }
}
