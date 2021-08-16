using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Models
{
    public class CartWeightItemModel : CartItemModel
    {
        public double WeightInKilo { get; set; }
        public decimal PricePerKilo { get; set; }
    }
}
