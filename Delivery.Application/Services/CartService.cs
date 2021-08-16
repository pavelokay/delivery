using Delivery.Application.Interfaces;
using Delivery.Application.Mapper;
using Delivery.Application.Models;
using Delivery.Core.Entities;
using Delivery.Core.Interfaces;
using Delivery.Core.Repositories;
using Delivery.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly IProductRepository _productRepository;
        private readonly IAppLogger<CartService> _logger;

        public CartService(ICartRepository cartRepository, IProductRepository productRepository, IAppLogger<CartService> logger)
        {
            _cartRepository = cartRepository ?? throw new ArgumentNullException(nameof(cartRepository));
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<CartModel> GetUserCart(ApplicationUserModel user)
        {
            var cart = await GetExistingOrCreateNewCart(user);
            var cartModel = ObjectMapper.Mapper.Map<CartModel>(cart);

            if (cart.Items.Any(c => c.Product == null))
            {
                cartModel.Items.Clear();
                foreach (var cartItem in cart.Items)
                {
                    var cartItemModel = ObjectMapper.Mapper.Map<CartItemModel>(cartItem);
                    var product = await _productRepository.GetProductByIdWithCategoryAsync(cartItem.ProductId);
                    var productModel = ObjectMapper.Mapper.Map<ProductModel>(product);
                    cartItemModel.Product = productModel;
                    cartModel.Items.Add(cartItemModel);
                }
            }

            return cartModel;
        }

        public async Task AddItem(ApplicationUserModel user, int productId, double weightInKilo, int quantity = 1)
        {
            var product = await _productRepository.GetByIdAsync(productId);
            if (product != null)
            {
                if (product is UnitProduct)
                {
                    await AddUnitItem(user, (UnitProduct)product, quantity);
                }
                else if (product is WeightProduct)
                {
                    await AddWeightItem(user, (WeightProduct)product, weightInKilo);
                }
                else
                {
                    throw new ApplicationException("product isn't unit-form or weight-form");
                }
            }
        }

        private async Task AddUnitItem(ApplicationUserModel user, UnitProduct product, int quantity = 1)
        {
            var cart = await GetExistingOrCreateNewCart(user);

            if (product != null)
            {
                var unitProduct = (UnitProduct)product;
                cart.AddUnitItem(product.Id, quantity: quantity, unitPrice: unitProduct.UnitPrice);
                await _cartRepository.UpdateAsync(cart);
            }
            else
            {
                throw new ApplicationException("product is null");
            }
        }

        private async Task AddWeightItem(ApplicationUserModel user, WeightProduct product, double weightInKilo)
        {
            var cart = await GetExistingOrCreateNewCart(user);

            if (product != null)
            {
                var weightProduct = (WeightProduct)product;
                cart.AddWeightItem(product.Id, weightInKilo: weightInKilo, pricePerKilo: weightProduct.PricePerKilo);
                await _cartRepository.UpdateAsync(cart);
            }
            else
            {
                throw new ApplicationException("product is null");
            }
        }

        public async Task RemoveItem(int cartId, int cartItemId)
        {
            var spec = new CartWithItemsSpecification(cartId);
            var cart = (await _cartRepository.GetAsync(spec)).FirstOrDefault();
            cart.RemoveItem(cartItemId);
            await _cartRepository.UpdateAsync(cart);
        }

        private async Task<Cart> GetExistingOrCreateNewCart(ApplicationUserModel user)
        {
            var cart = await _cartRepository.GetByUserNameAsync(user.UserName);
            if (cart != null)
            {
                return cart;
            }

            //var user = await _userRepository.GetUserByNameAsync(userName);
            var newCart = new Cart
            {
                UserId = user.Id
            };
            await _cartRepository.AddAsync(newCart);
            return newCart;
        }

        public async Task ClearCart(ApplicationUserModel user)
        {
            var cart = await _cartRepository.GetByUserNameAsync(user.UserName);

            if (cart == null)
            {
                throw new ApplicationException("Submitted order should have cart");
            }
            cart.ClearItems();

            await _cartRepository.UpdateAsync(cart);
        }

    }
}
