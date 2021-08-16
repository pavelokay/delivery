using Delivery.Application.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Models
{
    public class CategoryModel : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<CategoryImageModel> CategoryImages { get; set; }
    }
}
