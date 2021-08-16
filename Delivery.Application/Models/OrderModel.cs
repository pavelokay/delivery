using Delivery.Application.Models.Base;
using Delivery.Application.Models.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Models
{
    public class OrderModel : BaseModel
    {
        public DateTime OrderTime { get; set; }
        public DateTime DeliveryTime { get; set; }

        public decimal TotalPrice { get; set; }



        public OrderStatusModel Status { get; set; }
        public PaymentMethodModel PaymentMethod { get; set; }
        public DeliveryAddressModel Address { get; set; }


        public string UserId { get; set; }
        public ClientModel User { get; set; }


        public ICollection<OrderItemModel> Items { get; set; } = new List<OrderItemModel>();
    }

    public enum OrderStatusModel
    {
        Progress = 1,
        OnShipping = 2,
        Finished = 3,
        Canceled = 4
    }

    public enum PaymentMethodModel
    {
        BankTransfer = 1,
        Cash = 2,
        DigitalWalletTransfer = 3,
        Check = 4
    }
}
