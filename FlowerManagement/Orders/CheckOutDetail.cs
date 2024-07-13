using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerManagement.Orders
{
    public class CheckOutDetail
    {
        public int FlowerBouquetID { get; set; }

        public string? FlowerBouquetName { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? Quantity { get; set; }

        public decimal? Price { get; set; }
    }
}
