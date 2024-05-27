using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IOrderService
    {
        public Task<IList<Order>> GetOrders();
        public Task<bool> CreateOrder(Order order);
        public Task<bool> UpdateOrder(Order order);
        public Task<bool> DeleteOrder(Order order);
        public Task<Order> GetOrder(int id);
    }
}
