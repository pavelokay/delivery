using Delivery.Core.Entities;
using Delivery.Core.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Specifications
{
    public class CartWithItemsSpecification : BaseSpecification<Cart>
    {
        public CartWithItemsSpecification(string userName)
            : base(p => p.User.FirstName.ToLower().Contains(userName.ToLower()))
        {
            AddInclude(p => p.Items);
        }

        public CartWithItemsSpecification(int cartId)
            : base(p => p.Id == cartId)
        {
            AddInclude(p => p.Items);
        }
    }
}
