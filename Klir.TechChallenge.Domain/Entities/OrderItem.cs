using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.Domain.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int ProductId { get; set; }
        
        //this product should come with promotion as well
        public Product Product { get; set; }

        public int OrderId { get; set; }        

    }
}
