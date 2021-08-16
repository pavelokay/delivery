using Delivery.Application.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Models
{
    public class CartModel : BaseModel
    {
        public string UserId { get; set; }
        public ClientModel User { get; set; }
        public ICollection<CartItemModel> Items { get; set; }
    }
}
