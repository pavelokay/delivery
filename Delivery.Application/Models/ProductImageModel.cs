using Delivery.Application.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Models
{
    public class ProductImageModel : BaseModel
    {
        public int? ProductId { get; set; }
        public ProductModel Product { get; set; }
        public string AltName { get; set; }
        public string ImageFile { get; set; }
    }
}
