using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Application.Interfaces
{
    public interface IOrderService
    {
        //Task<IEnumerable<Product>> GetOrdersAsync();
        Task<OrderDTO> GetByIdAsync(int id);
        Task<OrderDTO> CreateOrderAsync(OrderDTO order);
    }
}
