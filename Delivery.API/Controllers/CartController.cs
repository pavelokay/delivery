using Delivery.Application.Interfaces;
using Delivery.Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;
        private readonly UserManager<ApplicationUserModel> _userManager;
        private readonly ILogger<CartController> _logger;

        public CartController(ICartService cartService, ILogger<CartController> logger)
        {
            _cartService = cartService ?? throw new ArgumentNullException(nameof(cartService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }


        [HttpGet]
        [Route("cart")]
        public async Task<CartModel> GetCart(ApplicationUserModel user)
        {
            if (user == null)
            {
                var userName = User.Identity.Name;
                user = await _userManager.FindByNameAsync(userName);
            }
            var cart = await _cartService.GetUserCart(user);
            return cart;
        }


        [HttpPut]
        [Route("cart")]
        public async Task<ActionResult> AddItem(ApplicationUserModel user, int productId, double weightInKilo, int quantity = 1)
        {
            if (user == null)
            {
                var userName = User.Identity.Name;
                user = await _userManager.FindByNameAsync(userName);
            }
            await _cartService.AddItem(user, productId, weightInKilo, quantity);
            return NoContent();
        }


        [HttpPut]
        [Route("cart")]
        public async Task<ActionResult> RemoveItem(int cartId, int cartItemId)
        {
            await _cartService.RemoveItem(cartId, cartItemId);
            return NoContent();
        }
    }
}
