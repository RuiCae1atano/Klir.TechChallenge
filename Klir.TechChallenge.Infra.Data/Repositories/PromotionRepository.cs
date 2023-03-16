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
    public class PromotionRepository : IPromotionRepository
    {
        ApplicationDbContext _context;

        public PromotionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Promotion> CreatePromotion(Promotion promotion)
        {
            await _context.Promotions.AddAsync(promotion); 
            return promotion;
        }

        public async Task<Promotion> GetById(int id)
        {
            return await _context.Promotions.FindAsync(id);
        }

        public async Task<IEnumerable<Promotion>> GetPromotions()
        {
            return await _context.Promotions.ToListAsync();
        }
    }
}
