namespace ProductSearchMicroservice.Domain.Models;

public class Product
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public required string Description { get; set; }

    public required double Price { get; set; }
}