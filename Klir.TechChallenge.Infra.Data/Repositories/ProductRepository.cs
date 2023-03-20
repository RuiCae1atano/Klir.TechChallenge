using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Domain.Interfaces;
using Klir.TechChallenge.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.Include(p => p.Promotion).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Product> GetProductPromotionAsync(int id)
        {
            return await _context.Products.Include(p => p.Promotion)
                 .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task UpdateProduct(Product product)
        {
            var prodToUpdate = await _context.Products.FindAsync(product.Id);
            if(prodToUpdate != null)
            _context.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
