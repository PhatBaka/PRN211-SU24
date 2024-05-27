using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IStaffService
    {
        public Task<IList<staff>> GetStaffs();
        public Task<bool> CreateStaff(staff staff);
        public Task<bool> UpdateStaff(staff staff);
        public Task<bool> DeleteStaff(staff staff);
        public Task<staff> GetStaff(int id);
    }
}
