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
    public class ManufacturerDataProvider : IManufacturerDataProvider
    {
        private readonly HttpClient _httpClient;

        public ManufacturerDataProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ManufacturerModel>> GetManufacturers()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<ManufacturerModel>>("api/Manufacturer/GetManufacturers");
        }

    }
}
