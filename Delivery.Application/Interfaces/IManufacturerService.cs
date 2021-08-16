using Delivery.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Interfaces
{
    public interface IManufacturerService
    {
        Task<IEnumerable<ManufacturerModel>> GetManufacturerList();
    }
}
