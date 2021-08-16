using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Entities
{
    public class CategoryImage
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required, StringLength(100)]
        public string AltName { get; set; }
        public string ImageFile { get; set; }
    }
}
