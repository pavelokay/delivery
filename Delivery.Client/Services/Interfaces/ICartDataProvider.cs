using Delivery.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Client.Services.Interfaces
{
    public interface ICartDataProvider
    {
        Task<CartModel> GetCart();

        Task AddItem(string userName, int productId, double? weightInKilo = 1, int? quantity = 1);
        Task RemoveItem(int cartId, int cartItemId);
    }
}
