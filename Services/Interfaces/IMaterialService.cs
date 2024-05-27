using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IMaterialService 
    {
        public Task<IList<Material>> GetMaterials();
        public Task<bool> CreateMaterial(Material material);
        public Task<bool> UpdateMaterial(Material material);
        public Task<bool> DeleteMaterial(Material material);
        public Task<Material> GetMaterial(int id);
    }
}
