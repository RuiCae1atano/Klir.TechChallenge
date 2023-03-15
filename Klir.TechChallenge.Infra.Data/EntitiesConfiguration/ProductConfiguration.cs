using Klir.TechChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Klir.TechChallenge.Infra.Data.EntitiesConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Price);
            builder.HasOne(e => e.Promotion).WithMany(e => e.Products)
                    .HasForeignKey(e => e.PromotionId);

            builder.HasData(
                    new Product(1,"Product A", 20, 1),
                    new Product(2,"Product B", 4, 2),
                    new Product(3,"Product C", 2,null),
                    new Product(4,"Product D", 4, 2)
                    );
        }
    }
}
