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

    public Task<Product> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetByNameAsync(string name)
    {
        throw new NotImplementedException();
    }
}