using WoC.Fit.Backend.Data.Models;
using WoC.Fit.Backend.Data.Repositories.Interfaces;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _productRepository.GetAllAsync();
    }

    public async Task<Product> GetProductByIdAsync(int id)
    {
        return await _productRepository.GetByIdAsync(id);
    }

    public async Task AddProductAsync(Product product)
    {
        await _productRepository.InsertAsync(product);
        await _productRepository.SaveAsync();
    }

    public async Task UpdateProductAsync(Product product)
    {
        _productRepository.Update(product);
        await _productRepository.SaveAsync();
    }

    public async Task DeleteProductAsync(int id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        if (product != null)
        {
            _productRepository.Delete(product);
            await _productRepository.SaveAsync();
        }
    }    
}
