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

    // [HttpGet]
    // [Route("id/{id}")]
    // public Product? GetById(int id)
    // {
    //
    // }
}