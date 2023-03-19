using AutoMapper;
using Klir.TechChallenge.Application.DTOs;
using Klir.TechChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.Application.Mappings
{
    public class DomainDTOMappingProfile : Profile
    {
        public DomainDTOMappingProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<OrderItem, OrderItemDTO>().ReverseMap();
            CreateMap<Promotion, PromotionDTO>().ReverseMap();
        }
    }
}
