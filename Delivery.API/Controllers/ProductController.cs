using AutoMapper;
using Delivery.Application.Interfaces;
using Delivery.Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        //private readonly ICartService _cartService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            //_cartService = cartService ?? throw new ArgumentNullException(nameof(cartService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        [Route("products")]
        public async Task<IEnumerable<ProductModel>> GetProducts(string productName) 
        {
            if (string.IsNullOrWhiteSpace(productName))
            {
                var products = await _productService.GetProductList();
                return products;

            }

            var productsByName = await _productService.GetProductByName(productName);
            return productsByName;
        }

        [HttpGet]
        [Route("product")]
        public async Task<ProductModel> GetProductById(int productId)
        {
            var product = await _productService.GetProductById(productId);
            return product;
        }

        [HttpGet]
        [Route("product")]
        public async Task<ProductModel> GetProductBySlug(string slug)
        {
            var product = await _productService.GetProductBySlug(slug);
            return product;
        }

        [HttpGet]
        [Route("product")]
        public async Task<IEnumerable<ProductModel>> GetProductByCategory(int categoryId)
        {
            var products = await _productService.GetProductByCategory(categoryId);
            return products;
        }


        [Authorize (Roles = "Admin")]
        [HttpPost]
        [Route("product")]
        public async Task<ActionResult> CreateProduct(ProductModel productModel)
        {
            var newProductModel = await _productService.Create(productModel);

            return CreatedAtAction(nameof(GetProducts), new { id = productModel.Id, }, newProductModel);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut]
        [Route("product")]
        public async Task<ActionResult> UpdateProduct(ProductModel productModel)
        {
            await _productService.Update(productModel);

            return NoContent();
        }

        [Authorize (Roles = "Admin")]
        [HttpDelete]
        [Route("product")]
        public async Task<ActionResult> DeleteProduct(int productId)
        {
            var productModel = await _productService.GetProductById(productId);
            if (productModel != null)
            {
                await _productService.Delete(productModel);
            }

            return NoContent();
        }

    }
}
