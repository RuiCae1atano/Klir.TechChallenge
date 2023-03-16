using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Domain.Interfaces;
using Klir.TechChallenge.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Infra.Data.Repositories
{
    public class OrderItemRepository : IOrderItemRepository
    {

        ApplicationDbContext _context;

        public OrderItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<OrderItem> GetByIdAsync(int id)
        {
            return await _context.OrderItems.FindAsync(id);
        }
    }
}
