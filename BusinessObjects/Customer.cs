﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    [Table("Customer")]
    public class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? CustomerName { get; set; }

        public string? City { get; set; }

        public string? Country { get; set; }

        public string? Password { get; set; }

        public string? CustomerStatus { get; set; }

        [Column(TypeName = "money")]
        public decimal Point { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
