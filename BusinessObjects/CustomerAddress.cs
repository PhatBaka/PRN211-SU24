using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class CustomerAddress
    {
        public int AddressId { get; set; }
        public int? CustomerId { get; set; }
        public string? Address { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
