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
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        private IAppLogger<OrderService> _logger;

        public OrderService(IOrderRepository orderRepository, IAppLogger<OrderService> logger)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<OrderModel> MakeOrder(OrderModel orderModel)
        {
            ValidateOrder(orderModel);

            var order = ObjectMapper.Mapper.Map<Order>(orderModel);
            if (order == null)
            {
                throw new ApplicationException($"Order could not be mapped");
            }

            var newOrder = await _orderRepository.AddAsync(order);
            _logger.LogInformation($"Order successfully added");

            var newOrderModel = ObjectMapper.Mapper.Map<OrderModel>(newOrder);
            return newOrderModel;
        }

        private void ValidateOrder(OrderModel orderModel)
        {
            if (string.IsNullOrWhiteSpace(orderModel.UserId))
            {
                throw new ApplicationException($"Order user must be defined");
            }

            if (orderModel.Items.Count <= 0)
            {
                throw new ApplicationException($"Order should have at least one item");
            }
            if (orderModel.Items.Count > 30)
            {
                throw new ApplicationException($"Order has maximum 30 items"); // 0 < Items <= 30
            }
        }
    }
}
