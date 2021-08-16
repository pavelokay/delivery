using Delivery.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Client.Services.Interfaces
{
    public interface IOrderDataProvider
    {
        Task MakeOrder(OrderModel orderModel, string userName);
    }
}
