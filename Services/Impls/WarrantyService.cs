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
    public class WarrantyService : IWarrantyService
    {
        private readonly IGenericRepository<Warranty> _warrantyRepository;

        public WarrantyService(IGenericRepository<Warranty> warrantyRepository)
        {
            _warrantyRepository = warrantyRepository;
        }

        public async Task<IList<Warranty>> GetWarranties()
        {
            try
            {
                var warranty = await _warrantyRepository.GetAllAsync();
                return warranty.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving warranty: {ex.Message}", ex);
            }
        }

        public async Task<bool> CreateWarranty(Warranty warranty)
        {
            try
            {
                return await _warrantyRepository.InsertAsync(warranty);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating warranty: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateWarranty(Warranty warranty)
        {
            try
            {
                return await _warrantyRepository.UpdateByIdAsync(warranty, warranty.WarrantyId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating warranty: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteWarranty(Warranty warranty)
        {
            try
            {
                return await _warrantyRepository.DeleteAsync(warranty);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting warranty: {ex.Message}", ex);
            }
        }

        public async Task<Warranty> GetWarranty(int id)
        {
            try
            {
                return await _warrantyRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving warranty by ID: {ex.Message}", ex);
            }
        }
    }
}

