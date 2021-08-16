using Delivery.Application.Interfaces;
using Delivery.Application.Mapper;
using Delivery.Application.Models;
using Delivery.Core.Entities;
using Delivery.Core.Interfaces;
using Delivery.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IAppLogger<ProductService> _logger;

        public ProductService(IProductRepository productRepository, IAppLogger<ProductService> logger)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<ProductModel>> GetProductList()
        {
            var products = await _productRepository.GetProductListAsync();
            var productsModel = ObjectMapper.Mapper.Map<IEnumerable<ProductModel>>(products);
            return productsModel;
        }

        public async Task<ProductModel> GetProductById(int productId)
        {
            var product = await _productRepository.GetByIdAsync(productId);
            var productModel = ObjectMapper.Mapper.Map<ProductModel>(product);
            return productModel;
        }

        public async Task<ProductModel> GetProductBySlug(string slug)
        {
            var product = await _productRepository.GetProductBySlug(slug);
            var productModel = ObjectMapper.Mapper.Map<ProductModel>(product);
            return productModel;
        }

        public async Task<IEnumerable<ProductModel>> GetProductByName(string productName)
        {
            var products = await _productRepository.GetProductByNameAsync(productName);
            var productsModel = ObjectMapper.Mapper.Map<IEnumerable<ProductModel>>(products);
            return productsModel;
        }

        public async Task<IEnumerable<ProductModel>> GetProductByCategory(int categoryId)
        {
            var products = await _productRepository.GetProductByCategoryAsync(categoryId);
            var productsModel = ObjectMapper.Mapper.Map<IEnumerable<ProductModel>>(products);
            return productsModel;
        }

        public async Task<ProductModel> Create(ProductModel productModel)
        {
            await ValidateProductIfExist(productModel);

            var product = ObjectMapper.Mapper.Map<Product>(productModel);
            if (product == null)
            {
                throw new ApplicationException($"Product entity could not be mapped.");
            }

            var newProduct = await _productRepository.AddAsync(product);
            _logger.LogInformation($"Product successfully added");

            var newProductModel = ObjectMapper.Mapper.Map<ProductModel>(newProduct);
            return newProductModel;
        }

        public async Task Update(ProductModel productModel)
        {
            await ValidateProductIfNotExist(productModel);

            var editProduct = await _productRepository.GetByIdAsync(productModel.Id);
            if (editProduct == null)
            {
                throw new ApplicationException($"Entity could not be loaded.");
            }

            ObjectMapper.Mapper.Map<ProductModel, Product>(productModel, editProduct);

            await _productRepository.UpdateAsync(editProduct);
            _logger.LogInformation($"Product successfully updated");
        }

        public async Task Delete(ProductModel productModel)
        {
            await ValidateProductIfNotExist(productModel);

            var deletedProduct = await _productRepository.GetByIdAsync(productModel.Id);
            if (deletedProduct == null)
            {
                throw new ApplicationException($"Entity could not be loaded.");
            }

            await _productRepository.DeleteAsync(deletedProduct);
            _logger.LogInformation($"Product successfully deleted");
        }




        private async Task ValidateProductIfExist(ProductModel productModel)
        {
            var existingProduct = await _productRepository.GetByIdAsync(productModel.Id);
            if (existingProduct != null)
            {
                throw new ApplicationException($"{productModel.ToString()} with this id already exists");
            }
        }

        private async Task ValidateProductIfNotExist(ProductModel productModel)
        {
            var existingProduct = await _productRepository.GetByIdAsync(productModel.Id);
            if (existingProduct == null)
            {
                throw new ApplicationException($"{productModel.ToString()} with this id isn't exists");
            }
        }
    }
}
