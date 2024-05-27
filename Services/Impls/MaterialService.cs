using BusinessObjects.Models;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Impls
{
    public class MaterialService : IMaterialService
    {
        private readonly IGenericRepository<Material> _materialRepository;

        public MaterialService(IGenericRepository<Material> materialRepository)
        {
            _materialRepository = materialRepository;
        }

        public async Task<IList<Material>> GetMaterials()
        {
            try
            {
                var material = await _materialRepository.GetAllAsync();
                return material.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving material: {ex.Message}", ex);
            }
        }

        public async Task<bool> CreateMaterial(Material material)
        {
            try
            {
                return await _materialRepository.InsertAsync(material);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating material: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateMaterial(Material material)
        {
            try
            {
                return await _materialRepository.UpdateByIdAsync(material, material.MaterialId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating material: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteMaterial(Material material)
        {
            try
            {
                return await _materialRepository.DeleteAsync(material);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting material: {ex.Message}", ex);
            }
        }

        public async Task<Material> GetMaterial(int id)
        {
            try
            {
                return await _materialRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving material by ID: {ex.Message}", ex);
            }
        }
    }
}

