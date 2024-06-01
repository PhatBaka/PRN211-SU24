using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Payments = new HashSet<Payment>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? OrderStatus { get; set; }
        public string? PayMethod { get; set; }
        public string? ShippingStatus { get; set; }
        public DateTime? ShippingDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? SaleStaffId { get; set; }
        public string? ShipperId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual staff? SaleStaff { get; set; }
        public virtual staff? Shipper { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
