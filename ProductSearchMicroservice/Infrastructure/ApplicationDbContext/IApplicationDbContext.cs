using Microsoft.EntityFrameworkCore;
using ProductSearchMicroservice.Domain.Models;

namespace ProductSearchMicroservice.Infrastructure.ApplicationDbContext;

public interface IApplicationDbContext
{
    public DbSet<Product> Products { get; set; }
}