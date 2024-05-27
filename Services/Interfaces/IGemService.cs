using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IGemService
    {
        public Task<IList<Gem>> GetGems();
        public Task<bool> CreateGem(Gem gem);
        public Task<bool> UpdateGem(Gem gem);
        public Task<bool> DeleteGem(Gem gem);
        public Task<Gem> GetGem(int id);
    }
}
