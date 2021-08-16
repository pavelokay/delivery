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
    public class ManufacturerRepository : Repository<Manufacturer>, IManufactuterRepository
    {
        public ManufacturerRepository(DeliveryContext context) : base(context) { }
    }
}
