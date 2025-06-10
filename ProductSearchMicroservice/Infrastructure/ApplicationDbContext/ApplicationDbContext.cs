using Microsoft.EntityFrameworkCore;
using ProductSearchMicroservice.Domain.Models;

namespace ProductSearchMicroservice.Infrastructure.ApplicationDbContext;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options), IApplicationDbContext
{
    public DbSet<Product> Products { get; set; }
}