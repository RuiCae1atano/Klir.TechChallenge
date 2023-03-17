using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Web.Api.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Api.Interfaces
{
    public interface IOrderService
    {
        //Task<IEnumerable<Product>> GetOrdersAsync();
        Task<OrderDTO> GetByIdAsync(int id);
        Task<OrderDTO> CreateOrderAsync(Order order);
    }
}
