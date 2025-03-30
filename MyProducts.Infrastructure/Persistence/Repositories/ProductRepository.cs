using Microsoft.EntityFrameworkCore;
using MyProducts.Core.Entities;
using MyProducts.Core.Repositories;

namespace MyProducts.Infrastructure.Persistence.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly MyProductsDbContext _dbContext;

    public ProductRepository(MyProductsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        var products = await _dbContext.Products.ToListAsync();
        return products;
    }
}