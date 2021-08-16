using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Entities
{
    public class CartWeightItem : CartItem
    {
        public double WeightInKilo { get; set; }

        [DataType(DataType.Currency)]
        public decimal PricePerKilo { get; set; }

    }
}
