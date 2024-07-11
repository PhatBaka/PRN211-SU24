using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    [Table("Supplier")]
    public class Supplier
    {
        public Supplier()
        {
            Flowers = new HashSet<Flower>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierID { get; set; }

        [Required]
        public string? SupplierName { get; set; }

        public string? SupplierAddress { get; set; }

        public string? Telephone { get; set; }

        public virtual ICollection<Flower> Flowers { get; set; }
    }
}
