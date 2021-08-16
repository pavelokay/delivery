using Delivery.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Entities
{
    public abstract class Product : Entity
    {
        [Required, StringLength(70)]
        public string Name { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        public double Rating { get; set; }
        public string Slug { get; set; }


        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ProductStatus Status { get; set; }


        public ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<ProductRelatedProduct> ProductRelatedProducts { get; set; } = new List<ProductRelatedProduct>();

        //public static Product Create(int productId, int categoryId, int manufacturerId, string name, decimal unitPrice = 0, double? unitsInStock = null)
        //{
        //}
    }

    public enum ProductStatus
    {
        inStore = 1,
        notAvailable =2
    }

}
