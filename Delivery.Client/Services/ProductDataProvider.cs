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
    public class ProductDataProvider : IProductDataProvider
    {
        private readonly HttpClient _httpClient;
        public ProductDataProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<ProductModel>> GetProducts()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<ProductModel>>("api/Product/GetProducts");
        } 

        public async Task<string> CreateProduct(ProductModel product)
        {
            var response =  await _httpClient.PostAsJsonAsync<ProductModel>("api/Product/CreateProduct", product);
            string apiResponse = await response.Content.ReadAsStringAsync();
            return apiResponse;
        }

        public async Task<string> UpdateProduct(ProductModel product)
        {
            var response = await _httpClient.PutAsJsonAsync<ProductModel>("api/Product/UpdateProduct", product);
            string apiResponse = await response.Content.ReadAsStringAsync();
            return apiResponse;
        }

        public async Task<string> DeleteProduct(int productId)
        {
            var response = await _httpClient.DeleteAsync($"api/Product/CreateProduct/{productId}");
            string apiResponse = await response.Content.ReadAsStringAsync();
            return apiResponse;
        }
    }
}
