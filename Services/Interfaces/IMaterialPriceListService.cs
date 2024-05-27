using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IMaterialPriceListService
    {
        public Task<IList<MaterialPriceList>> GetMaterialPriceLists();
        public Task<bool> CreateMaterialPriceList(MaterialPriceList materialPriceList);
        public Task<bool> UpdateMaterialPriceList(MaterialPriceList materialPriceList);
        public Task<bool> DeleteMaterialPriceList(MaterialPriceList materialPriceList);
        public Task<MaterialPriceList> GetMaterialPriceList(int id);
    }
}
