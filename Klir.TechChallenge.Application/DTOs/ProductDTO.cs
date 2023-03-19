using Klir.TechChallenge.Domain.Entities;

namespace Klir.TechChallenge.Application.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public PromotionDTO Promotion{ get; private set; }
        public int? PromotionId { get; private set; }
        public string PromotionName { get; set; }
    }
}
