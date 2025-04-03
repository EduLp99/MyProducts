using Microsoft.EntityFrameworkCore;
using MyProducts.Core.Entities;
using MyProducts.Core.Repositories;

namespace MyProducts.Infrastructure.Persistence.Repositories;

/// <summary>
/// Repositório responsável pelo acesso e manipulação dos dados da entidade Product.
/// </summary>
public class ProductRepository : IProductRepository
{
    private readonly MyProductsDbContext _dbContext;

    /// <summary>
    /// Construtor da classe ProductRepository.
    /// </summary>
    /// <param name="dbContext">Contexto do banco de dados utilizado para acessar os produtos.</param>
    public ProductRepository(MyProductsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Obtém todos os produtos cadastrados no banco de dados.
    /// </summary>
    /// <returns>Uma coleção de produtos.</returns>
    public async Task<IEnumerable<Product>> GetAll()
    {
        var products = await _dbContext.Products.ToListAsync();
        return products;
    }
}
