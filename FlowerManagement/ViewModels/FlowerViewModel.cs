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
    public class FlowerViewModel
    {
        public int FlowerBouquetID { get; set; }

        public string? FlowerBouquetName { get; set; }

        public string? Description { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public string? Morphology { get; set; }

        public byte[]? Image { get; set; }

        public string? CategoryName { get; set; }

        public string? SupplierName { get; set; }
    }
}
