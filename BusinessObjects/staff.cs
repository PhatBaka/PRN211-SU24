using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class staff
    {
        public staff()
        {
            OrderSaleStaffs = new HashSet<Order>();
            OrderShippers = new HashSet<Order>();
        }

        public string StaffId { get; set; } = null!;
        public int? AccountId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public virtual Account? Account { get; set; }
        public virtual ICollection<Order> OrderSaleStaffs { get; set; }
        public virtual ICollection<Order> OrderShippers { get; set; }
    }
}
