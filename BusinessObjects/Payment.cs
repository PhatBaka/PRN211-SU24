using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int? OrderId { get; set; }
        public int? CustomerId { get; set; }
        public string? PayMethod { get; set; }
        public decimal? Deposits { get; set; }
        public string? PayDetail { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Order? Order { get; set; }
    }
}
