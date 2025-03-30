using Microsoft.AspNetCore.Mvc;
using MyProducts.Core.Entities;
using MyProducts.Core.Repositories;

namespace MyProducts.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductsController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    [HttpGet]
    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        var products = await _productRepository.GetAll();
        return products;
    }
}