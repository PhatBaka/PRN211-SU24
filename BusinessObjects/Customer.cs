using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerAddresses = new HashSet<CustomerAddress>();
            Orders = new HashSet<Order>();
            Payments = new HashSet<Payment>();
        }

        public int CustomerId { get; set; }
        public int? AccountId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Point { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        public virtual Account? Account { get; set; }
        public virtual Membership? Membership { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
