using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Domain.Interfaces;
using Klir.TechChallenge.Application.DTOs;
using Klir.TechChallenge.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace Klir.TechChallenge.Application.Services
{
    public class PromotionService : IPromotionService
    {

        private IPromotionRepository _repository;
        private readonly IMapper _mapper;

        public PromotionService(IPromotionRepository promotionRepository, IMapper mapper)
        {
            _repository = promotionRepository;
            _mapper = mapper;
        }
        public async Task<bool> CreatePromotion(PromotionDTO promotionDTO)
        {
            var promotionEntity = _mapper.Map<Promotion>(promotionDTO);
            await _repository.CreatePromotion(promotionEntity); 
            return true;
        }

        public async Task<PromotionDTO> GetById(int id)
        {
            var promotionEntity = await _repository.GetById(id);
            var promotionDTO = _mapper.Map<PromotionDTO>(promotionEntity);

            return promotionDTO;
        }

        public async Task<IEnumerable<PromotionDTO>> GetPromotions()
        {
            var promotionEntity = await _repository.GetPromotions();
            var promotionDTO = _mapper.Map<IEnumerable<PromotionDTO>>(promotionEntity);


            return promotionDTO;
        }
    }
}
