﻿using Delivery.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Entities
{
    public class Category : Entity
    {
        [Required, StringLength(80)]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<CategoryImage> CategoryImages { get; set; }

        public static Category Create(int categoryId, string name, string description = null)
        {
            var category = new Category
            {
                Id = categoryId,
                Name = name,
                Description = description
            };
            return category;
        }
    }
}
