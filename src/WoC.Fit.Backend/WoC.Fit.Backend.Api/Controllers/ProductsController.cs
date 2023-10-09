using Mapster;
using Microsoft.AspNetCore.Mvc;
using WoC.Fit.Backend.Api.ViewModels;
using WoC.Fit.Backend.Data.Models;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    // GET: api/Products
    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await _productService.GetAllProductsAsync();        
        return Ok((products.Adapt<List<ProductVM>>()));
    }

    // GET: api/Products/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(int id)
    {
        var product = await _productService.GetProductByIdAsync(id);

        if (product == null)
        {
            return NotFound();
        }

        return Ok(product);
    }

    // POST: api/Products
    [HttpPost]
    public async Task<IActionResult> AddProduct([FromBody] Product product)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _productService.AddProductAsync(product);
        return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
    }

    // PUT: api/Products/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(int id, [FromBody] Product product)
    {
        if (!ModelState.IsValid || id != product.Id)
        {
            return BadRequest();
        }

        try
        {
            await _productService.UpdateProductAsync(product);
        }
        catch
        {
            // You might want to add more specific error handling here.
            return NotFound();
        }

        return NoContent();
    }

    // DELETE: api/Products/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var product = await _productService.GetProductByIdAsync(id);
        if (product == null)
        {
            return NotFound();
        }

        await _productService.DeleteProductAsync(id);
        return NoContent();
    }
}
