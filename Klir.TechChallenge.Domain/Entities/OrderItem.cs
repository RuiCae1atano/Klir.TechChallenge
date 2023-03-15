using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.Domain.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(int id, int orderId, int productId, int quantity)
        {
            Id = id;
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
        }

        public OrderItem(int id, int productId, int quantity)
        {
            Id = id;
            ProductId = productId;
            Quantity = quantity;
        }

        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }     
        public Order Order { get; set; }
    }
}
