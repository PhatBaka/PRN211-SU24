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
    public class OrderService : IOrderService
    {
        private readonly IGenericRepository<Order> _orderRepository;

        public OrderService(IGenericRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IList<Order>> GetOrders()
        {
            try
            {
                var order = await _orderRepository.GetAllAsync();
                return order.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving order: {ex.Message}", ex);
            }
        }

        public async Task<bool> CreateOrder(Order order)
        {
            try
            {
                return await _orderRepository.InsertAsync(order);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating order: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateOrder(Order order)
        {
            try
            {
                return await _orderRepository.UpdateByIdAsync(order, order.OrderId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating order: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteOrder(Order order)
        {
            try
            {
                return await _orderRepository.DeleteAsync(order);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting order: {ex.Message}", ex);
            }
        }

        public async Task<Order> GetOrder(int id)
        {
            try
            {
                return await _orderRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving order by ID: {ex.Message}", ex);
            }
        }
    }
}

