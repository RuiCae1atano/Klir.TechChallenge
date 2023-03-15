using Klir.TechChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.Infra.Data.EntitiesConfiguration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Total);
            builder.HasMany(o => o.OrderItems)
                .WithOne(or => or.Order).HasForeignKey(or => or.OrderId);    

            builder.HasData(
                    new Product(1, "Product A", 20, 1),
                    new Product(2, "Product B", 4, 2),
                    new Product(3, "Product C", 2, null),
                    new Product(4, "Product D", 4, 2)
                    );
        }
    }
}
