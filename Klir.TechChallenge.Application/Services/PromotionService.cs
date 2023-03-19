using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Domain.Interfaces;
using Klir.TechChallenge.Infra.IoC;
using Klir.TechChallenge.Application.DTOs;
using Klir.TechChallenge.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Application.Services
{
    public class PromotionService : IPromotionService
    {

        private IPromotionRepository _repository;
        public PromotionService(IPromotionRepository promotionRepository)
        {
            _repository = promotionRepository;
        }
        public async Task<PromotionDTO> CreatePromotion(PromotionDTO promotion)
        {
            var promo = new Promotion(promotion.Name);

            await _repository.CreatePromotion(promo);
            return promotion;
        }

        public async Task<PromotionDTO> GetById(int id)
        {
            var promotion = await _repository.GetById(id);
            PromotionDTO promotionDTO = promotion.ToDto<Promotion, PromotionDTO>();
            return promotionDTO;
        }

        public async Task<IEnumerable<PromotionDTO>> GetPromotions()
        {
            var promotion = await _repository.GetPromotions();
            var promotionDTO = new List<PromotionDTO>();
            foreach (var pr in promotion)
            {
                promotionDTO.Add(pr.ToDto<Promotion, PromotionDTO>());
            }

            return promotionDTO;
        }
    }
}
