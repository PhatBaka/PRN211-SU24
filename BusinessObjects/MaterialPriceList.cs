using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class MaterialPriceList
    {
        public int Id { get; set; }
        public int? MaterialId { get; set; }
        public decimal? UnitPrice { get; set; }
        public DateTime? EffDate { get; set; }

        public virtual Material? Material { get; set; }
    }
}
