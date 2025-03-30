using Microsoft.EntityFrameworkCore;
using MyProducts.Core.Entities;

namespace MyProducts.Infrastructure.Persistence;

public class MyProductsDbContext(DbContextOptions<MyProductsDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
}