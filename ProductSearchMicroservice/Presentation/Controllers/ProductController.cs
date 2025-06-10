using Microsoft.AspNetCore.Mvc;
using ProductSearchMicroservice.Domain.Models;
using ProductSearchMicroservice.Domain.Repositories;

namespace ProductSearchMicroservice.Presentation.Controllers;

[Route("[controller]")]
[ApiController]
public class ProductController(IProductRepository productRepository)
{
    [HttpGet]
    [Route("all")]
    public async Task<List<Product>> GetAll()
    {
        return await productRepository.GetAll();
    }

    [HttpGet]
    [Route("id/{id}")]
    public async Task<Product?> GetById(int id)
    {
        return await productRepository.GetByIdAsync(id);
    }

    [HttpGet]
    [Route("name/{name}")]
    public async Task<Product?> GetByName(string name)
    {
        return await productRepository.GetByNameAsync(name);
    }
}