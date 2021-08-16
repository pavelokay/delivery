using Delivery.Application.Interfaces;
using Delivery.Application.Mapper;
using Delivery.Application.Models;
using Delivery.Core.Interfaces;
using Delivery.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private IAppLogger<CategoryService> _logger;

        public CategoryService(ICategoryRepository categoryRepository, IAppLogger<CategoryService> logger)
        {
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<CategoryModel>> GetCategoryList()
        {
            var categories = await _categoryRepository.GetAllAsync();
            var categoriesModel = ObjectMapper.Mapper.Map<IEnumerable<CategoryModel>>(categories);

            return categoriesModel;
        }
    }
}
