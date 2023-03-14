using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.Domain.Entities
{
    public sealed class Product : Entity
    {
        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }

        public int PromotionId { get; private set; }
        public Promotion Promotion { get; private set; }

        public Product(string name)
        {
            Name = name;
        }
    }
}
