using Delivery.Application.Interfaces;
using Delivery.Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Delivery.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ICartService _cartService;
        private readonly ILogger<OrderController> _logger;
        public OrderController(IOrderService orderService, ICartService cartService, ILogger<OrderController> logger)
        {
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
            _cartService = cartService ?? throw new ArgumentNullException(nameof(cartService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        /// <summary>
        /// Make order based on user's cart
        /// </summary>
        /// <param name="order"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> MakeOrder(OrderModel order, ApplicationUserModel user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            var cart = await _cartService.GetUserCart(user);
            TransformCartToOrder(cart, order);
            order.UserId = user.Id;
            await _orderService.MakeOrder(order);
            return StatusCode(201);
        }
        /// <summary>
        /// Transform user's cart to order
        /// </summary>
        /// <param name="cart"></param>
        /// <param name="order"></param>
        private void TransformCartToOrder(CartModel cart, OrderModel order)
        {
            foreach (var cartItem in cart.Items)
            {
                if (cartItem is CartUnitItemModel)
                {
                    CartUnitItemModel cartUnitItem = (CartUnitItemModel)cartItem;
                    order.Items.Add(
                        new OrderUnitItemModel
                        {
                            ProductId = cartUnitItem.ProductId,
                            Product = cartUnitItem.Product,
                            Quantity = cartUnitItem.Quantity,
                            TotalPrice = cartUnitItem.TotalPrice,
                            UnitPrice = cartUnitItem.UnitPrice
                        });
                }
                else if (cartItem is CartWeightItemModel)
                {
                    CartWeightItemModel cartWeightItem = (CartWeightItemModel)cartItem;
                    order.Items.Add(
                        new OrderWeightItemModel
                        {
                            ProductId = cartWeightItem.ProductId,
                            Product =cartWeightItem.Product,
                            PricePerKilo = cartWeightItem.PricePerKilo,
                            WeightInKilo = cartWeightItem.WeightInKilo,
                            TotalPrice = cartWeightItem.TotalPrice
                        });
                }
            }
        }
    }
}
