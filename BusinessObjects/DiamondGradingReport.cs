using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class DiamondGradingReport
    {
        public int ReportId { get; set; }
        public int? GemId { get; set; }
        public DateTime? GenerateDate { get; set; }
        public byte[]? Image { get; set; }

        public virtual Gem? Gem { get; set; }
    }
}
