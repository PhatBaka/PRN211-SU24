using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    [Table("Flower")]
    public class Flower
    {
        public Flower()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FlowerBouquetID { get; set; }

        [Required]
        public string? FlowerBouquetName { get; set; }

        public string? Description { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Required]
        public int UnitsInStock { get; set; }

        public bool FlowerBouquetStatus { get; set; }

        public string? Morphology { get; set; }

        public byte[]? Image { get; set; }

        [Required]
        public int CategoryID { get; set; }

        public virtual Category? Category { get; set; }

        [Required]
        public int SupplierID { get; set; }

        public virtual Supplier? Supplier { get; set; }

        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
