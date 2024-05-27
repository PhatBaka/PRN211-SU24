using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class Membership
    {
        public int CustomerId { get; set; }
        public string? Rank { get; set; }
        public decimal? DiscountRate { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}
