using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    [Table("Order")]
    public class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime ShippedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal FinalPrice { get; set; }

        [Column(TypeName = "float")]
        public float Discount { get; set; }

        public string? OrderStatus { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer? Customer { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
