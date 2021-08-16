using Delivery.Application.Models;
using Delivery.Client.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Delivery.Client.Services
{
    public class CartDataProvider : ICartDataProvider
    {
        private readonly HttpClient _httpClient;

        public CartDataProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<CartModel> GetCart()
        {
            return await _httpClient.GetFromJsonAsync<CartModel>("api/Cart/GetCart");
        }

        public async Task AddItem(string userName, int productId, double? weightInKilo = 1, int? quantity = 1)
        {
            var jsonString = JsonSerializer.Serialize(new { userName = userName, productId = productId, weightInKilo = weightInKilo, quantity = quantity });
            var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var message = await _httpClient.PutAsync("api/Cart/AddItem", httpContent);
        }

        public async Task RemoveItem(int cartId, int cartItemId)
        {
            var jsonString = JsonSerializer.Serialize(new { cartId = cartId, cartItemId = cartItemId });
            var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var message = await _httpClient.PutAsync("api/Cart/RemoveItem", httpContent);
        }
    }
}
