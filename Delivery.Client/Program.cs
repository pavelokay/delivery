using Delivery.Client.Services;
using Delivery.Client.Services.Account;
using Delivery.Client.Services.Account.Base;
using Delivery.Client.Services.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");


            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddHttpClient("Delivery.API")
                .AddHttpMessageHandler(sp =>
                {
                    var handler = sp.GetService<AuthorizationMessageHandler>()
                        .ConfigureHandler(
                            authorizedUrls: new[] { "https://localhost:5002" },
                            scopes: new[] { "deliveryapi" }
                        );
                    return handler;
                });

            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>()
                .CreateClient("Delivery.API"));

            //sbuilder.Services.AddApiAuthorization()
            //    .AddAccountClaimsPrincipalFactory<CustomUserFactory>();

            builder.Services.AddOidcAuthentication(options =>
            {
                builder.Configuration.Bind("oidc", options.ProviderOptions);
                options.UserOptions.RoleClaim = "role";
            })
                .AddAccountClaimsPrincipalFactory<CustomUserFactory>();



            builder.Services.AddSingleton<IProductDataProvider, ProductDataProvider>();
            builder.Services.AddSingleton<ICartDataProvider, CartDataProvider>();
            builder.Services.AddSingleton<IOrderDataProvider, OrderDataProvider>();
            builder.Services.AddSingleton<ICategoryDataProvider, CategoryDataProvider>();
            builder.Services.AddSingleton<IManufacturerDataProvider, ManufacturerDataProvider>();

            builder.Services.AddSingleton<IAuthenticationDataProvider, AuthenticationDataProvider>();

            await builder.Build().RunAsync();
        }
    }
}
