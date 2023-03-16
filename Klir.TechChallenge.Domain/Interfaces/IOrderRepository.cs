using Klir.TechChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Domain.Interfaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Product>> GetOrdersAsync();
        Task<Order> GetByIdAsync(int id);
        Task<Order> CreateOrderAsync(Order order);
    }
}
