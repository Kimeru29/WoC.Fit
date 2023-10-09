using Microsoft.EntityFrameworkCore;
using WoC.Fit.Backend.Data.Models;
using WoC.Fit.Backend.Data.Repositories.Interfaces;

namespace WoC.Fit.Backend.Data.Repositories
{

    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly NutriContext _context;

        public ProductRepository(NutriContext context) : base(context)
        {
            _context = context;            
        }

        public async Task<IEnumerable<Product>> GetProductsWithIncludes()
        {
            var products = await _context.Products
                        .Include(p => p.Brand)
                        .Include(p => p.ProductType)
                        .Include(p => p.MainMacronutrient)
                        .Include(p => p.PortionType)
                        .ToListAsync();

            return products;

        }

    }

}
