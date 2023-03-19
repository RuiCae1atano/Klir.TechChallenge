using Klir.TechChallenge.Domain.Entities;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Application.Interfaces
{
    public interface IOrderItemService
    {
        Task<OrderItem> GetByIdAsync(int id);
    }
}
