using Delivery.Core.Entities;
using Delivery.Core.Repositories;
using Delivery.Core.Specifications;
using Delivery.Infrastructure.Data;
using Delivery.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Infrastructure.Repository
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        public CartRepository(DeliveryContext dbContext) : base(dbContext)
        {

        }

        public async Task<Cart> GetByUserNameAsync(string userName)
        {
            var spec = new CartWithItemsSpecification(userName);
            return (await GetAsync(spec)).FirstOrDefault();
        }
    }
}
