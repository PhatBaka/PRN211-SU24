using BusinessObjects;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICustomerService 
    {
        public Task<IList<Customer>> GetCustomers();
        public Task<bool> CreateCustomer(Customer customer);
        public Task<bool> UpdateCustomer(Customer customer);
        public Task<bool> DeleteCustomer(Customer customer);
        public Task<Customer> GetCustomer(int id);
    }
}
