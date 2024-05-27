using BusinessObjects;
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
    public class AccountService : IAccountService
    {
        private readonly IGenericRepository<Account> _accountRepository;

        public AccountService(IGenericRepository<Account> accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<IList<Account>> GetAccounts()
        {
            try
            {
                var accounts = await _accountRepository.GetAllAsync();
                return accounts.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving accounts: {ex.Message}", ex);
            }
        }

        public async Task<bool> CreateAccount(Account account)
        {
            try
            {
                return await _accountRepository.InsertAsync(account);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating account: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateAccount(Account account)
        {
            try
            {
                return await _accountRepository.UpdateByIdAsync(account, account.AccountId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating account: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteAccount(Account account)
        {
            try
            {
                return await _accountRepository.DeleteAsync(account);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting account: {ex.Message}", ex);
            }
        }

        public async Task<Account> GetAccount(int id)
        {
            try
            {
                return await _accountRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving account by ID: {ex.Message}", ex);
            }
        }
    }
}
