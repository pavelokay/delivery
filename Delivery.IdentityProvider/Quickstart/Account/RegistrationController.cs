using Delivery.IdentityProvider.Models;
using IdentityModel;
using IdentityServer4;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Delivery.IdentityProvider.Quickstart.Account
{
    [AllowAnonymous]
    public class RegistrationController : Controller
    {
        private readonly UserManager<LoginUser> _userManager;
        private readonly IdentityServerTools _tools;



        public RegistrationController(
            UserManager<LoginUser> userManager,
            IdentityServerTools tools)
        {
            _userManager = userManager;
            _tools = tools;
        }

        [HttpGet]
        public IActionResult Register(string returnUrl)
        {
            return View(new RegisterViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(vm.UserName);
                if (user == null)
                {
                    user = new LoginUser
                    {
                        UserName = vm.UserName,
                        Email = vm.Email,
                        PhoneNumber = vm.Phone
                    };

                    var result = await _userManager.CreateAsync(user, vm.Password);
                    if (!result.Succeeded)
                    {

                    }

                    result = await _userManager.AddClaimsAsync(user, new Claim[]{
                        new Claim(JwtClaimTypes.Name, vm.UserName),
                        new Claim(JwtClaimTypes.GivenName, vm.FirstName),
                        new Claim(JwtClaimTypes.FamilyName, vm.LastName)
                    });

                    if (!result.Succeeded)
                    {

                    }

                    if (!await RegisterBusinessUser(vm) == true)
                    {

                    }


                }
                return View();
            }
            return View(vm);
        }


        private async Task<bool> RegisterBusinessUser(RegisterViewModel vm)
        {
            // token to call protected api
            //var token = await _tools.IssueClientJwtAsync(
            //    clientId: "IdentityServer",
            //    lifetime: 3600,
            //    audiences: new[] { "deliveryapi" });
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsJsonAsync<RegisterViewModel>("api/account/Register", vm))
                {
                    if (((int)response.StatusCode) != 201)
                    {
                        //error
                    }
                }
            }
            return true;

        }
    }
}
