using Delivery.Application.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Models
{
    public class CategoryImageModel : BaseModel
    {
        public int? CategoryId { get; set; }
        public CategoryModel Category { get; set; }
        public string AltName { get; set; }
        public string ImageFile { get; set; }
    }
}
