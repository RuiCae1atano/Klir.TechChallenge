using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Domain.Interfaces;
using Klir.TechChallenge.Infra.IoC;
using Klir.TechChallenge.Web.Api.DTOs;
using Klir.TechChallenge.Web.Api.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Api.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _repository;
        public ProductService(IProductRepository orderRepository)
        {
            _repository = orderRepository;
        }

        public async Task<ProductDTO> GetByIdAsync(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            ProductDTO productDTO = product.ToDto<Product, ProductDTO>();
            return productDTO;
        }

        public async Task<ProductDTO> GetProductPromotionAsync(int id)
        {
            var product = await _repository.GetProductPromotionAsync(id);
            ProductDTO productDTO = product.ToDto<Product, ProductDTO>();
            return productDTO;
        }

        public async Task<IEnumerable<ProductDTO>> GetProductsAsync()
        {
            var product = await _repository.GetProductsAsync();
            List<ProductDTO> products = new List<ProductDTO>();
            foreach (var pr in product)
            {
                ProductDTO productDTO = pr.ToDto<Product, ProductDTO>();
                products.Add(productDTO);
            }
            return products;
        }
    }
}
