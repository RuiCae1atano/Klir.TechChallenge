using Klir.TechChallenge.Domain.Entities;

namespace Klir.TechChallenge.Web.Api.DTOs
{
    public class OrderItemDTO
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
