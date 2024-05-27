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
    public class MembershipService : IMembershipService
    {
        private readonly IGenericRepository<Membership> _membershipRepository;

        public MembershipService(IGenericRepository<Membership> membershipRepository)
        {
            _membershipRepository = membershipRepository;
        }

        public async Task<IList<Membership>> GetMemberships()
        {
            try
            {
                var membership = await _membershipRepository.GetAllAsync();
                return membership.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving membership: {ex.Message}", ex);
            }
        }

        public async Task<bool> CreateMembership(Membership membership)
        {
            try
            {
                return await _membershipRepository.InsertAsync(membership);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating member ship: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateMembership(Membership membership)
        {
            try
            {
                return await _membershipRepository.UpdateByIdAsync(membership, membership.Customer);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating member ship: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteMembership(Membership membership)
        {
            try
            {
                return await _membershipRepository.DeleteAsync(membership);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting member ship: {ex.Message}", ex);
            }
        }

        public async Task<Membership> GetMembership(int id)
        {
            try
            {
                return await _membershipRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving member ship by ID: {ex.Message}", ex);
            }
        }
    }
}

