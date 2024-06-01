using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class GemPriceList
    {
        public int Id { get; set; }
        public string? Origin { get; set; }
        public decimal? CaratWeight { get; set; }
        public string? Color { get; set; }
        public string? Clarity { get; set; }
        public string? Cut { get; set; }
        public decimal? Price { get; set; }
        public DateTime? EffDate { get; set; }
        public decimal? Size { get; set; }
    }
}
