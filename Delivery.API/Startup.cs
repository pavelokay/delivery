using Delivery.Application.Interfaces;
using Delivery.Application.Services;
using Delivery.Core.Entities;
using Delivery.Core.Interfaces;
using Delivery.Core.Repositories;
using Delivery.Core.Repositories.Base;
using Delivery.Infrastructure.Data;
using Delivery.Infrastructure.Logging;
using Delivery.Infrastructure.Repository;
using Delivery.Infrastructure.Repository.Base;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Delivery.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureDeliveryServices(services);
            //services.AddMvc();

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Delivery.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Delivery.API v1"));
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseCookiePolicy();

            app.UseRouting();

            app.UseIdentityServer();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }


        private void ConfigureDeliveryServices(IServiceCollection services)
        {
            ConfigureDatabases(services);
            ConfigureSecurity(services);
            //ConfigureIdentity(services);

            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IManufacturerService, ManufacturerService>();

            services.AddAutoMapper(typeof(Startup));

            services.AddHttpContextAccessor();
            services.AddHealthChecks();

        }

        private void ConfigureDatabases(IServiceCollection services)
        {
            services.AddDbContext<DeliveryContext>(c => c.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), m => m.MigrationsAssembly("Delivery.API")));
        }

        private void ConfigureSecurity(IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = "https://localhost:5000";
                    options.Audience = "deliveryapi";
                });
        }

        //private void ConfigureIdentity(IServiceCollection services)
        //{
            //services.AddScoped<ApplicationUserClaimsPrincipalFactory>();

            //services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<DeliveryContext>();
            //services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)  // change to true
            //    .AddRoles<IdentityRole>()
            //    .AddEntityFrameworkStores<DeliveryContext>()
            //    .AddClaimsPrincipalFactory<ApplicationUserClaimsPrincipalFactory>();

            //services.AddIdentityServer()
            //    .AddApiAuthorization<ApplicationUser, DeliveryContext>(options => {
            //        options.IdentityResources["openid"].UserClaims.Add("name");
            //        options.ApiResources.Single().UserClaims.Add("name");
            //        options.IdentityResources["openid"].UserClaims.Add("role");
            //        options.ApiResources.Single().UserClaims.Add("role");
            //    });

            //JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Remove("role");

            //services.Configure<IdentityOptions>(options =>
            //{
            //    options.Password.RequiredLength = 6;
            //    options.ClaimsIdentity.UserIdClaimType = ClaimTypes.NameIdentifier;
            //});
        //}
    }
}
