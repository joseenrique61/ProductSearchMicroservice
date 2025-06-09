using Microsoft.AspNetCore.Mvc;
using ProductSearchMicroservice.Models;

namespace ProductSearchMicroservice.Controllers;

[Route("[controller]")]
[ApiController]
public class ProductController
{
    [HttpGet]
    [Route("all")]
    public List<Product> GetAll()
    {
        return
        [
            new Product()
            {
                Id = 0,
                Name = "Balón de fútbol",
                Price = 2.7
            }
        ];
    }
}