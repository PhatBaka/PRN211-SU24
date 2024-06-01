using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class Warranty
    {
        public int WarrantyId { get; set; }
        public int? OrderDetailId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual OrderDetail? OrderDetail { get; set; }
    }
}
