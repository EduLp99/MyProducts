using MyProducts.Core.Entities;

namespace MyProducts.Core.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAll();
}