using BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerManagement.ViewModels
{
    internal class SupplierViewModel
    {
        public int SupplierID { get; set; }

        [Required]
        public string? SupplierName { get; set; }

        public string? SupplierAddress { get; set; }

        public string? Telephone { get; set; }
    }
}
