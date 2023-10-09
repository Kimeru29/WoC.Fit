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

        // Implement any specific methods related to Product here.
        // Example:
        // public IEnumerable<Product> GetProductsByBrand(string brandName)
        // {
        //     return _context.Products.Where(p => p.Brand.Name == brandName).ToList();
        // }
    }

}
