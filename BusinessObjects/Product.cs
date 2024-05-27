using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
            ProductMaterials = new HashSet<ProductMaterial>();
            Gems = new HashSet<Gem>();
        }

        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public string? Description { get; set; }
        public int? CategoryId { get; set; }
        public decimal? MaterialCost { get; set; }
        public decimal? GemCost { get; set; }
        public decimal? DifferentCost { get; set; }
        public decimal? ProductionCost { get; set; }
        public decimal? PriceRate { get; set; }
        public string? ProductSize { get; set; }
        public byte[]? Image { get; set; }

        public virtual ProductCategory? Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductMaterial> ProductMaterials { get; set; }

        public virtual ICollection<Gem> Gems { get; set; }
    }
}
