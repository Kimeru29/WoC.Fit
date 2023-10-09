using WoC.Fit.Backend.Data.Models;

namespace WoC.Fit.Backend.Data.Repositories.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsWithIncludes();
    }

}
