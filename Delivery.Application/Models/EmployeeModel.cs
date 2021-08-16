using Delivery.Application.Models.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Models
{
    public class EmployeeModel : ApplicationUserModel
    {
        public UserAddressModel WorkAddress { get; set; }
        public DateTime HideDate { get; set; }
    }
}
