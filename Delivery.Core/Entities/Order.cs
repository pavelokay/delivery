using Delivery.Core.Entities.Base;
using Delivery.Core.Entities.ValueObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Entities
{
    public class Order : Entity
    {
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime OrderTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DataType DeliveryTime { get; set; }

        [DataType(DataType.Currency)]
        public decimal TotalPrice { get; set; }




        public OrderStatus Status { get; set; }
        public DeliveryAddress DeliveryAddress { get; set; }
        public PaymentMethod PaymentMethod { get; set; }



        public string UserId { get; set; }
        public ApplicationUser User { get; set; }


        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
    }

    public enum OrderStatus
    {
        Progress = 1,
        OnShipping = 2,
        Finished = 3,
        Canceled = 4
    }

    public enum PaymentMethod
    {
        BankTransfer = 1,
        Cash =2,
        DigitalWalletTransfer = 3,
        Check = 4
    }
}
