using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IGemPriceListService 
    {
        public Task<IList<GemPriceList>> GetGemPriceLists();
        public Task<bool> CreateGemPriceList(GemPriceList gemPriceList);
        public Task<bool> UpdateGemPriceList(GemPriceList gemPriceList);
        public Task<bool> DeleteGemPriceList(GemPriceList gemPriceList);
        public Task<GemPriceList> GetGemPriceList(int id);
    }
}
