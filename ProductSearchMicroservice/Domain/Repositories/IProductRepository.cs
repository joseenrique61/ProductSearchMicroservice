using ProductSearchMicroservice.Domain.Models;

namespace ProductSearchMicroservice.Domain.Repositories;

public interface IProductRepository
{
    public Task<List<Product>> GetAll();

    public Task<Product?> GetByIdAsync(int id);

    public Task<Product?> GetByNameAsync(string name);
}