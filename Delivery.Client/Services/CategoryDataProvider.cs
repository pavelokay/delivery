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
    public class CategoryDataProvider : ICategoryDataProvider
    {
        private readonly HttpClient _httpClient;

        public CategoryDataProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<CategoryModel>> GetCategories()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<CategoryModel>>("api/category/GetCategories");
        }
    }
}
