using Delivery.Core.Entities;
using Delivery.Core.Repositories;
using Delivery.Infrastructure.Data;
using Delivery.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Infrastructure.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DeliveryContext dbContext) : base(dbContext)
        {

        }


    }
}
