using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetByIdAsync(int id);
        Task<ProductDTO> GetProductPromotionAsync(int id);

        Task UpdateProduct(ProductDTO productDTO);
    }
}
