using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public string? CustomizedSize { get; set; }
        public decimal? CustomizedAmount { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? FinalPrice { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
        public virtual Warranty? Warranty { get; set; }
    }
}
