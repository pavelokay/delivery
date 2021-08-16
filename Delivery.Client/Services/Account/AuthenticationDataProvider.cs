using Delivery.Application.Models;
using Delivery.Application.Models.Account;
using Delivery.Client.Services.Account.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Delivery.Client.Services.Account
{
    public class AuthenticationDataProvider : IAuthenticationDataProvider
    {
        private readonly HttpClient _httpClient;

        public AuthenticationDataProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //public async Task<ApplicationUserModel> GetCurrentUser()
        //{
        //    var user = await _httpClient.Get
        //}

        public async Task RegisterUser(RegisterUserModel userForRegistration)
        {
            var result = await _httpClient.PostAsJsonAsync<RegisterUserModel>("api/Account/Register", userForRegistration);
        }

        public async Task LoginUser(LoginUserModel userForLogin)
        {
            var result = await _httpClient.PostAsJsonAsync<LoginUserModel>("api/Account/Login", userForLogin);
        }

        public async Task UpdateUser(EditUserModel userForEdit)
        {
            var result = await _httpClient.PutAsJsonAsync<EditUserModel>("api/Account/UpdateUser", userForEdit);
        }

        public async Task DeleteUser(string userId)
        {
            var result = await _httpClient.DeleteAsync($"api/Account/DeleteUser/{userId}");
        }
    }
}
