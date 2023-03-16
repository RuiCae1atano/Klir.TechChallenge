using Klir.TechChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Domain.Interfaces
{
    public interface IOrderItemRepository
    {
        Task<OrderItem> GetByIdAsync(int id);
    }
}
