﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Models
{
    public class OrderUnitItemModel : OrderItemModel
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
