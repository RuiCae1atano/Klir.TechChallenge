using Klir.TechChallenge.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.Domain.Entities
{
    public sealed class Promotion : Entity
    {
        public string Name { get; private set; }

        public ICollection<Product> Products { get; set; }

        public Promotion(string name)
        {
            ValidateDomain(name);
        }

        public Promotion(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Id Invalid value");
            ValidateDomain(name);
        }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), 
                "Invalid name.Name is required");
            Name = name;
        }

    }
}
