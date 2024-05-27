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
    public class StaffService : IStaffService
    {
        private readonly IGenericRepository<staff> _staffRepository;

        public StaffService(IGenericRepository<staff> staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public async Task<IList<staff>> GetStaffs()
        {
            try
            {
                var staff = await _staffRepository.GetAllAsync();
                return staff.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving staff: {ex.Message}", ex);
            }
        }

        public async Task<bool> CreateStaff(staff staff)
        {
            try
            {
                return await _staffRepository.InsertAsync(staff);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating staff: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateStaff(staff staff)
        {
            try
            {
                return await _staffRepository.UpdateByIdAsync(staff, staff.StaffId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating staff: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteStaff(staff staff)
        {
            try
            {
                return await _staffRepository.DeleteAsync(staff);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting staff: {ex.Message}", ex);
            }
        }

        public async Task<staff> GetStaff(int id)
        {
            try
            {
                return await _staffRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving staff by ID: {ex.Message}", ex);
            }
        }
    }
}

