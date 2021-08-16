using Delivery.Application.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Models
{
    public abstract class ProductModel : BaseModel
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }


        public int? CategoryId { get; set; }
        public CategoryModel Category { get; set; }

        public int? ManufacturerId { get; set; }
        public ManufacturerModel Manufacturer { get; set; }

        public ICollection<ProductImageModel> ProductImages { get; set; } = new List<ProductImageModel>();
    }
}
