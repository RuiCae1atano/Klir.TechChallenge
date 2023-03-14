using Klir.TechChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Domain.Interfaces
{
    public interface IPromotionRepository
    {
        Task<IEnumerable<Promotion>> GetPromotions();
        Task<Promotion> GetById(int id);
        Task<Promotion> AddPromotion(Promotion promotion);
    }
}
