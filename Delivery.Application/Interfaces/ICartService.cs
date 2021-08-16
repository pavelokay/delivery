using Delivery.Application.Models;
using Delivery.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Interfaces
{
    public interface ICartService
    {
        Task<CartModel> GetUserCart(ApplicationUserModel user);
        Task AddItem(ApplicationUserModel user, int productId, double weightInKilo, int quanity);
        Task RemoveItem(int cartId, int cartItemId);
        Task ClearCart(ApplicationUserModel user);
    }
}
