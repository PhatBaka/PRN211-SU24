﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace FlowerManagement.Orders
{
    public class FlowerDetailDTO
    {
        public int FlowerBouquetID { get; set; }

        public string? FlowerBouquetName { get; set; }

        public string? Description { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public bool FlowerBouquetStatus { get; set; }

        public string? Morphology { get; set; }

        public byte[]? Image { get; set; }

        public string? CategoryName { get; set; }

        public string? SupplierName { get; set; }
    }
}
