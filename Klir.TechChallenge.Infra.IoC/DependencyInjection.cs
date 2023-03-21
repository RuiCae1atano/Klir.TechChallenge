using Klir.TechChallenge.Infra.Data.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Klir.TechChallenge.Infra.Data.Repositories;
using Klir.TechChallenge.Domain.Interfaces;
using Klir.TechChallenge.Application.Interfaces;
using Klir.TechChallenge.Application.Services;
using Klir.TechChallenge.Application.Mappings;

namespace Klir.TechChallenge.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
                IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>
                (options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
                });
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            services.AddScoped<IPromotionRepository, PromotionRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IPromotionService, PromotionService>();
            services.AddAutoMapper(typeof(DomainDTOMappingProfile));

            return services;
        }
    }
}
