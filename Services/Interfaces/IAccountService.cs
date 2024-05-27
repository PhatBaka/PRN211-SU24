using BusinessObjects;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAccountService
    {
        public Task<IList<Account>> GetAccounts();
        public Task<bool> CreateAccount(Account account);
        public Task<bool> UpdateAccount(Account account);
        public Task<bool> DeleteAccount(Account account);
        public Task<Account> GetAccount(int id);
    }
}
