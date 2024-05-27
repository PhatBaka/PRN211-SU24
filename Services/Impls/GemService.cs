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
    public class GemService : IGemService
    {
        private readonly IGenericRepository<Gem> _gemRepository;

        public GemService(IGenericRepository<Gem> gemRepository)
        {
            _gemRepository = gemRepository;
        }

        public async Task<IList<Gem>> GetGems()
        {
            try
            {
                var gem = await _gemRepository.GetAllAsync();
                return gem.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving gem: {ex.Message}", ex);
            }
        }

        public async Task<bool> CreateGem(Gem gem)
        {
            try
            {
                return await _gemRepository.InsertAsync(gem);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating gem: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateGem(Gem gem)
        {
            try
            {
                return await _gemRepository.UpdateByIdAsync(gem, gem.GemId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating gem: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteGem(Gem gem)
        {
            try
            {
                return await _gemRepository.DeleteAsync(gem);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting gem: {ex.Message}", ex);
            }
        }

        public async Task<Gem> GetGem(int id)
        {
            try
            {
                return await _gemRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving gem by ID: {ex.Message}", ex);
            }
        }
    }
}

