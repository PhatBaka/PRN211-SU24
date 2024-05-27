using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class Gem
    {
        public Gem()
        {
            Products = new HashSet<Product>();
        }

        public int GemId { get; set; }
        public string? GemName { get; set; }
        public string? Polish { get; set; }
        public string? Symmetry { get; set; }
        public string? Fluorescence { get; set; }
        public string? Origin { get; set; }
        public decimal? CaratWeight { get; set; }
        public string? Color { get; set; }
        public string? Cut { get; set; }
        public string? Clarity { get; set; }
        public string? Shape { get; set; }

        public virtual DiamondGradingReport? DiamondGradingReport { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
