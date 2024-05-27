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
    public class CustomerService : ICustomerService
    {
        private readonly IGenericRepository<Customer> _customerRepository;

        public CustomerService(IGenericRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IList<Customer>> GetCustomers()
        {
            try
            {
                var customers = await _customerRepository.GetAllAsync();
                return customers.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving customers: {ex.Message}", ex);
            }
        }

        public async Task<bool> CreateCustomer(Customer customer)
        {
            try
            {
                return await _customerRepository.InsertAsync(customer);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating customer: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateCustomer(Customer customer)
        {
            try
            {
                return await _customerRepository.UpdateByIdAsync(customer, customer.CustomerId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating customer: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteCustomer(Customer customer)
        {
            try
            {
                return await _customerRepository.DeleteAsync(customer);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting customer: {ex.Message}", ex);
            }
        }

        public async Task<Customer> GetCustomer(int id)
        {
            try
            {
                return await _customerRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving customer by ID: {ex.Message}", ex);
            }
        }
    }
}
