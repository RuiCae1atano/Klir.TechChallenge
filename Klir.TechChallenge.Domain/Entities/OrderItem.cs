using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.Domain.Entities
{
    public class OrderItem : Entity
    {
        public int Quantity { get; set; }
        public int Price { get; set; }
        public ICollection<OrderItemProduct> OrderItemProducts { get; set; }

        public int OrderId { get; set; }        
        public Order Order { get; set; }

        public OrderItem(int quantity, int price, int orderId)
        {
            Quantity = quantity;
            Price = price;
            OrderId = orderId;
        }

    }
}
