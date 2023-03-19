using Klir.TechChallenge.Domain.Entities;

namespace Klir.TechChallenge.Application.DTOs
{
    public class OrderItemDTO
    {
        public OrderItemDTO(int quantity, string productName, decimal productPrice, string promotionName)
        {
            Quantity = quantity;
            ProductName = productName;
            ProductPrice = productPrice;
            PromotionName = promotionName;
        }

        public int? ProductId { get; set; }
        public int? OrderId { get; set; }
        public int Quantity { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }
        public string PromotionName { get; set; }


        public ProductDTO Product { get; set; }
        public OrderDTO Order { get; set; }

    }
}
