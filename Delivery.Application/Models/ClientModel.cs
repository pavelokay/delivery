using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Models
{
    public class ClientModel : ApplicationUserModel
    {
        public ICollection<OrderModel> Orders { get; set; } = new List<OrderModel>();
    }
}
