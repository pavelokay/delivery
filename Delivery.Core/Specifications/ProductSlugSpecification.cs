using Delivery.Core.Entities;
using Delivery.Core.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Specifications
{
    public class ProductSlugSpecification : BaseSpecification<Product>
    {
        public ProductSlugSpecification(string slug)
            : base(p => p.Slug.ToLower().Contains(slug.ToLower()))
        {
            AddInclude(p => p.Category);
            AddInclude(p => p.Reviews);
        }
    }
}
