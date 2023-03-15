namespace Klir.TechChallenge.Domain.Entities
{
    public class OrderItemProduct : Entity
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public OrderItem OrderItem { get; set; }
        public Product Product { get; set; }

        public OrderItemProduct(int orderItemId, int productId)
        {
            OrderItemId = orderItemId;
            ProductId = productId;
        }
    }
}