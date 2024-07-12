using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        [Required]
        public int OrderID { get; set; }

        [Key]
        [Required]
        public int FlowerBouquetID { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public virtual Order? Order { get; set; }

        public virtual Flower? Flower { get; set; }
    }
}
