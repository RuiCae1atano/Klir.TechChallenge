using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Application.Interfaces;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Application.Services
{
    public class OrderItemService : IOrderItemService
    {
        public Task<OrderItem> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
