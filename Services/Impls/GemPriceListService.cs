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
    public class GemPriceListService : IGemPriceListService
    {
        private readonly IGenericRepository<GemPriceList> _gemPriceListRepository;

        public GemPriceListService(IGenericRepository<GemPriceList> gemPriceListRepository)
        {
            _gemPriceListRepository = gemPriceListRepository;
        }

        public async Task<IList<GemPriceList>> GetGemPriceLists()
        {
            try
            {
                var gemPriceList = await _gemPriceListRepository.GetAllAsync();
                return gemPriceList.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving gem price list: {ex.Message}", ex);
            }
        }

        public async Task<bool> CreateGemPriceList(GemPriceList GemPriceList)
        {
            try
            {
                return await _gemPriceListRepository.InsertAsync(GemPriceList);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating gem price list: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateGemPriceList(GemPriceList gemPriceList)
        {
            try
            {
                return await _gemPriceListRepository.UpdateByIdAsync(gemPriceList, gemPriceList.Id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating gem price list: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteGemPriceList(GemPriceList gemPriceList)
        {
            try
            {
                return await _gemPriceListRepository.DeleteAsync(gemPriceList);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting gem price list: {ex.Message}", ex);
            }
        }

        public async Task<GemPriceList> GetGemPriceList(int id)
        {
            try
            {
                return await _gemPriceListRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving gem price list by ID: {ex.Message}", ex);
            }
        }
    }
}

