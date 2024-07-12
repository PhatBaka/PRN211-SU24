using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerManagement.Orders
{
    public class OrderDTO
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal FinalPrice { get; set; }

        public float Discount { get; set; }

        public string? OrderStatus { get; set; }

    }
}
