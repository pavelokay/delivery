using Delivery.Application.Models;
using Delivery.Client.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Delivery.Client.Services
{
    public class OrderDataProvider : IOrderDataProvider
    {
        private readonly HttpClient _httpClient;

        public OrderDataProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task MakeOrder(OrderModel orderModel, string userName)
        {
            await _httpClient.PostAsJsonAsync("api/Order/MakeOrder", orderModel);
        }
    }
}
