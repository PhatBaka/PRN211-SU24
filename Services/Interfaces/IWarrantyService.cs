using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IWarrantyService
    {
        public Task<IList<Warranty>> GetWarranties();
        public Task<bool> CreateWarranty(Warranty warranty);
        public Task<bool> UpdateWarranty(Warranty warranty);
        public Task<bool> DeleteWarranty(Warranty warranty);
        public Task<Warranty> GetWarranty(int id);
    }
}
