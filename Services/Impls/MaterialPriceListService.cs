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
    public class MaterialPriceListService : IMaterialPriceListService
    {
        private readonly IGenericRepository<MaterialPriceList> _materialPriceListRepository;

        public MaterialPriceListService(IGenericRepository<MaterialPriceList> materialPriceListRepository)
        {
            _materialPriceListRepository = materialPriceListRepository;
        }

        public async Task<IList<MaterialPriceList>> GetMaterialPriceLists()
        {
            try
            {
                var materialPriceList = await _materialPriceListRepository.GetAllAsync();
                return materialPriceList.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving material price list: {ex.Message}", ex);
            }
        }

        public async Task<bool> CreateMaterialPriceList(MaterialPriceList materialPriceList)
        {
            try
            {
                return await _materialPriceListRepository.InsertAsync(materialPriceList);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating material price list: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateMaterialPriceList(MaterialPriceList materialPriceList)
        {
            try
            {
                return await _materialPriceListRepository.UpdateByIdAsync(materialPriceList, materialPriceList.Id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating material price list: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteMaterialPriceList(MaterialPriceList materialPriceList)
        {
            try
            {
                return await _materialPriceListRepository.DeleteAsync(materialPriceList);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting material price list: {ex.Message}", ex);
            }
        }

        public async Task<MaterialPriceList> GetMaterialPriceList(int id)
        {
            try
            {
                return await _materialPriceListRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving material price list by ID: {ex.Message}", ex);
            }
        }
    }
}

