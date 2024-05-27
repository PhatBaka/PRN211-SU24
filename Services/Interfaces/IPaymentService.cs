using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IPaymentService
    {
        public Task<IList<Payment>> GetPayments();
        public Task<bool> CreatePayment(Payment payment);
        public Task<bool> UpdatePayment(Payment payment);
        public Task<bool> DeletePayment(Payment payment);
        public Task<Payment> GetPayment(int id);
    }
}
