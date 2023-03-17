using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Web.Api.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Api.Interfaces
{
    public interface IPromotionService
    {
        Task<IEnumerable<PromotionDTO>> GetPromotions();
        Task<PromotionDTO> GetById(int id);
        Task<PromotionDTO> CreatePromotion(PromotionDTO promotion);
    }
}
