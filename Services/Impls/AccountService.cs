using BusinessObjects;
using Repositories.Impls;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Impls
{
    public class AccountService : IAccountService
    {
        public Task<bool> InsertAccount(Account account) => GenericRepository<Account>.Instance.InsertAsync(account);

        public Task UpdateAccount(Account account, int id) => GenericRepository<Account>.Instance.UpdateByIdAsync(account, id);

        public Task<bool> DeleteAccount(Account account) => GenericRepository<Account>.Instance.DeleteAsync(account);

        public Task<Account> GetAccountById(int id) => GenericRepository<Account>.Instance.GetByIdAsync(id);

        public Task<IQueryable<Account>> GetAccounts() => GenericRepository<Account>.Instance.GetAllAsync();
    }
}
