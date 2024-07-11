using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAccountService
    {
        public Task<bool> InsertAccount(Account account);
        public Task UpdateAccount(Account account, int id);
        public Task<bool> DeleteAccount(Account account);
        public Task<Account> GetAccountById(int id);
        public Task<IQueryable<Account>> GetAccounts();
    }
}
