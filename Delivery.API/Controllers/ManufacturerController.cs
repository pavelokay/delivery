using Delivery.Application.Interfaces;
using Delivery.Application.Models;
using Delivery.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _manufacturerService;
        private readonly IAppLogger<ManufacturerController> _logger;

        public ManufacturerController(IManufacturerService manufacturerService, IAppLogger<ManufacturerController> logger)
        {
            _manufacturerService = manufacturerService ?? throw new ArgumentNullException(nameof(manufacturerService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public async Task<IEnumerable<ManufacturerModel>> GetManufacturers()
        {
            return await _manufacturerService.GetManufacturerList();
        }
    }
}
