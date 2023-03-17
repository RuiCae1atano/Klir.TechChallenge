using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Web.Api.Interfaces;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Api.Services
{
    public class OrderItemService : IOrderItemService
    {
        public Task<OrderItem> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
