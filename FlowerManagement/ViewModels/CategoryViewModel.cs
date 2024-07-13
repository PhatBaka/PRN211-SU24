using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerManagement.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }

        public string? CategoryName { get; set; }

        public string? CategoryDescription { get; set; }

        public string? CategoryNote { get; set; }
    }
}
