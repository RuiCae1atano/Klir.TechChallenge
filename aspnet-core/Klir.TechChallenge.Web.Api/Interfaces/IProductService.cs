using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Web.Api.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Api.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetByIdAsync(int id);
        Task<ProductDTO> GetProductPromotionAsync(int id);
    }
}
