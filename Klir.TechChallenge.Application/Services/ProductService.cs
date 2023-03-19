using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Domain.Interfaces;
using Klir.TechChallenge.Application.DTOs;
using Klir.TechChallenge.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace Klir.TechChallenge.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _repository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository orderRepository, IMapper mapper)
        {
            _repository = orderRepository;
            _mapper = mapper;
        }

        public async Task<ProductDTO> GetByIdAsync(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            var productDTO = _mapper.Map<ProductDTO>(product);
            return productDTO;
        }

        public async Task<ProductDTO> GetProductPromotionAsync(int id)
        {
            var product = await _repository.GetProductPromotionAsync(id);
            var productDTO = _mapper.Map<ProductDTO>(product);
            return productDTO;
        }

        public async Task<IEnumerable<ProductDTO>> GetProductsAsync()
        {
            var product = await _repository.GetProductsAsync();
            var productDTO = _mapper.Map<IEnumerable<ProductDTO>>(product);

            return productDTO;
        }
    }
}
