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
    public class PaymentService : IPaymentService
    {
        private readonly IGenericRepository<Payment> _paymentRepository;

        public PaymentService(IGenericRepository<Payment> paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<IList<Payment>> GetPayments()
        {
            try
            {
                var payment = await _paymentRepository.GetAllAsync();
                return payment.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving payment: {ex.Message}", ex);
            }
        }

        public async Task<bool> CreatePayment(Payment payment)
        {
            try
            {
                return await _paymentRepository.InsertAsync(payment);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating payment: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdatePayment(Payment payment)
        {
            try
            {
                return await _paymentRepository.UpdateByIdAsync(payment, payment.PaymentId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating payment: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeletePayment(Payment payment)
        {
            try
            {
                return await _paymentRepository.DeleteAsync(payment);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting payment: {ex.Message}", ex);
            }
        }

        public async Task<Payment> GetPayment(int id)
        {
            try
            {
                return await _paymentRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving payment by ID: {ex.Message}", ex);
            }
        }
    }
}

