using Microsoft.EntityFrameworkCore;
using ProductSearchMicroservice.Domain.Models;
using ProductSearchMicroservice.Domain.Repositories;
using ProductSearchMicroservice.Infrastructure.ApplicationDbContext;

namespace ProductSearchMicroservice.Infrastructure.Repositories;

public class ProductRepository(IApplicationDbContext dbContext) : IProductRepository
{
    public async Task<List<Product>> GetAll()
    {
        return await dbContext.Products.ToListAsync();
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        return await dbContext.Products.FindAsync(id);
    }

    public async Task<Product?> GetByNameAsync(string name)
    {
        return await dbContext.Products.FirstAsync(x => x.Name == name);
    }
}