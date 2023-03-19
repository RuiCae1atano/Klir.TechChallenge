using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Application.Interfaces
{
    public interface IPromotionService
    {
        Task<IEnumerable<PromotionDTO>> GetPromotions();
        Task<PromotionDTO> GetById(int id);
        Task<PromotionDTO> CreatePromotion(PromotionDTO promotion);
    }
}
