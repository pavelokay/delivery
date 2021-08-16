using Delivery.Application.Models.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Models
{
    public class ApplicationUserModel
    {
        public string Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public UserAddressModel Address { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<OrderModel> Orders { get; set; } = new List<OrderModel>();



        public WorkAddressModel WorkAddress { get; set; }

        public DateTime HireDate { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
    }
}
