using Delivery.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Entities
{
    public class Cart : Entity
    {
        public ICollection<CartItem> Items { get; set; } = new List<CartItem>();

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        /// <summary>
        /// Add unit-form Item to cart
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        /// <param name="unitPrice"></param>
        public void AddUnitItem(int productId, int quantity = 1, decimal unitPrice = 0)
        {
            var existingItem = Items.FirstOrDefault(p => p.Product.Id == productId);
            var unitCartItem = existingItem as CartUnitItem;

            if (unitCartItem != null)
            {
                unitCartItem.Quantity++;
                unitCartItem.TotalPrice = unitCartItem.Quantity * unitCartItem.UnitPrice;
            }
            else if (existingItem == null)
            {
                var newItem = new CartUnitItem()
                {
                    ProductId = productId,
                    Quantity = quantity,
                    UnitPrice = unitPrice,
                    TotalPrice = quantity * unitPrice
                };
                Items.Add(newItem);
            }
        }
        /// <summary>
        /// Add weight-form Item to cart
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="weightInKilo"></param>
        /// <param name="pricePerKilo"></param>
        public void AddWeightItem(int productId, double weightInKilo = 1, decimal pricePerKilo = 0)
        {
            var existingItem = Items.FirstOrDefault(p => p.Product.Id == productId);
            var weightCartItem = existingItem as CartWeightItem;

            if (weightCartItem != null)
            {
                weightCartItem.WeightInKilo += weightInKilo;
                weightCartItem.TotalPrice = (Decimal)weightCartItem.WeightInKilo * weightCartItem.PricePerKilo; // !!! Double to Decimal cast
            }
            else if (existingItem == null)
            {
                var newItem = new CartWeightItem()
                {
                    ProductId = productId,
                    WeightInKilo = weightInKilo,
                    PricePerKilo = pricePerKilo,
                    TotalPrice = (Decimal)weightInKilo * pricePerKilo  // !!! Double to Decimal cast
                };
                Items.Add(newItem);
            }
        }

        //public void AddItem(int productId, int quantity = 1, decimal unitPrice = 0, double weightInKilo = 1, decimal pricePerKilo = 0)
        //{
        //    var existingItem = Items.FirstOrDefault(p => p.Product.Id == productId);
        //    if (existingItem != null)
        //    {
        //        if (existingItem is CartUnitItem)
        //        {
        //            var unitCartItem = (CartUnitItem)existingItem;

        //            unitCartItem.Quantity++;
        //            unitCartItem.TotalPrice = unitCartItem.Quantity * unitCartItem.UnitPrice;
        //        }
        //        if (existingItem is CartWeightItem)
        //        {
        //            var weightCartItem = (CartWeightItem)existingItem;

        //            weightCartItem.WeightInKilo += weightInKilo;
        //            weightCartItem.TotalPrice = (Decimal)weightCartItem.WeightInKilo * weightCartItem.PricePerKilo; // !!! Double to Decimal cast
        //        }
        //    }
        //    else
        //    {
        //    }
        //}

        public void RemoveCartItem(int cartProductId)
        {
            var removedItem= Items.FirstOrDefault(p => p.Id == cartProductId);
            if (removedItem != null)
            {
                Items.Remove(removedItem);
            }
        }

        public void RemoveItem(int productId)
        {
            var removedItem = Items.FirstOrDefault(p => p.ProductId == productId);
            if (removedItem!= null)
            {
                Items.Remove(removedItem);
            }
        }

        public void ClearItems()
        {
            Items.Clear();
        }

    }
}
