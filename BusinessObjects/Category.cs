using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessObjects
{
    [Table("Category")]
    public class Category
    {
        public Category()
        {
            Flowers = new HashSet<Flower>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

        [Required]
        public string? CategoryName { get; set; }

        public string? CategoryDescription { get; set; }

        public string? CategoryNote { get; set; }
        public virtual ICollection<Flower>? Flowers { get; set; }
    }
}
