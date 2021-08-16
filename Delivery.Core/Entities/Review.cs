using Delivery.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Entities
{
    public class Review : Entity
    {
        [Required, StringLength(700)]
        public string Comment { get; set; }
        public double Rating { get; set; }



        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
