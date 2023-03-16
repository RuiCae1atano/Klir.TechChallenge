using Klir.TechChallenge.Domain.Entities;

namespace Klir.TechChallenge.Web.Api.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Promotion Promotion{ get; set; }
        public int? PromotionId { get; private set; }
    }
}
