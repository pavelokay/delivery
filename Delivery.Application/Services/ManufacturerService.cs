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
    public class ManufacturerService : IManufacturerService
    {
        private IManufactuterRepository _manufactuterRepository;
        private IAppLogger<ManufacturerService> _logger;

        public ManufacturerService(IManufactuterRepository manufactuterRepository, IAppLogger<ManufacturerService> logger)
        {
            _manufactuterRepository = manufactuterRepository ?? throw new ArgumentNullException(nameof(manufactuterRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<IEnumerable<ManufacturerModel>> GetManufacturerList()
        {
            var manufacturers = await _manufactuterRepository.GetAllAsync();
            var manufacturersModel = ObjectMapper.Mapper.Map<IEnumerable<ManufacturerModel>>(manufacturers);

            return manufacturersModel;
        } 
    }
}
