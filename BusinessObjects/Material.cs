using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class Material
    {
        public Material()
        {
            MaterialPriceLists = new HashSet<MaterialPriceList>();
            ProductMaterials = new HashSet<ProductMaterial>();
        }

        public int MaterialId { get; set; }
        public string? MaterialName { get; set; }

        public virtual ICollection<MaterialPriceList> MaterialPriceLists { get; set; }
        public virtual ICollection<ProductMaterial> ProductMaterials { get; set; }
    }
}
