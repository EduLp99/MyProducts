using Microsoft.AspNetCore.Mvc;
using MyProducts.Core.Entities;
using MyProducts.Core.Repositories;

namespace MyProducts.Controllers;

/// <summary>
/// Controller responsável por gerenciar operações relacionadas aos produtos.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    /// <summary>
    /// Construtor da classe ProductsController.
    /// Optei por não utilizar service pois não tem regra de negócio
    /// </summary>
    /// <param name="productRepository">Repositório de produtos utilizado para acessar os dados.</param>
    public ProductsController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    /// <summary>
    /// Obtém todos os produtos cadastrados no sistema.
    /// </summary>
    /// <returns>Uma coleção de produtos.</returns>
    [HttpGet]
    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        var products = await _productRepository.GetAll();
        return products;
    }
}
