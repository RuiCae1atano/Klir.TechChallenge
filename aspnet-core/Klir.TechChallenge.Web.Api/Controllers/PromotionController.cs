using Klir.TechChallenge.Application.DTOs;
using Klir.TechChallenge.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        private readonly IPromotionService _service;
        public PromotionController(IPromotionService promotionService)
        {
            _service = promotionService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var promotions = await _service.GetById(id);
            return Ok(promotions);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePromotion(PromotionDTO promotionDTO)
        {
            var promotions = await _service.CreatePromotion(promotionDTO);
            return Ok(promotions);
        }
    }
}
