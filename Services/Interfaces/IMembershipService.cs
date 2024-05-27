using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IMembershipService 
    {
        public Task<IList<Membership>> GetMemberships();
        public Task<bool> CreateMembership(Membership membership);
        public Task<bool> UpdateMembership(Membership membership);
        public Task<bool> DeleteMembership(Membership membership);
        public Task<Membership> GetMembership(int id);
    }
}
