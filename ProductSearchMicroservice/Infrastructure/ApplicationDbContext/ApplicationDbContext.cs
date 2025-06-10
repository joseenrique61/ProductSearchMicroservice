using Microsoft.EntityFrameworkCore;
using ProductSearchMicroservice.Domain.Models;

namespace ProductSearchMicroservice.Infrastructure.ApplicationDbContext;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options), IApplicationDbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Café Premium", Description = "Café de origen colombiano.", Price = 4.99 },
            new Product { Id = 2, Name = "Auriculares Inalámbricos", Description = "Bluetooth 5.0 y cancelación de ruido.", Price = 24.99 },
            new Product { Id = 3, Name = "Teclado Mecánico", Description = "Switches rojos y retroiluminación RGB.", Price = 59.99 },
            new Product { Id = 4, Name = "Silla Ergonómica", Description = "Diseño lumbar para largas jornadas.", Price = 129.99 },
            new Product { Id = 5, Name = "Lámpara LED", Description = "Luz blanca cálida y fría con sensor táctil.", Price = 15.99 },
            new Product { Id = 6, Name = "Notebook 15.6\"", Description = "8GB RAM, 256GB SSD, Ryzen 5.", Price = 499.99 },
            new Product { Id = 7, Name = "Mochila Antirrobo", Description = "Compartimientos secretos y USB externo.", Price = 34.90 },
            new Product { Id = 8, Name = "Batería Portátil 10000mAh", Description = "Carga rápida con doble salida.", Price = 22.50 },
            new Product { Id = 9, Name = "Botella Térmica", Description = "Mantiene frío o calor por 12 horas.", Price = 18.70 },
            new Product { Id = 10, Name = "Mouse Gamer", Description = "Sensor óptico 7200 DPI con RGB.", Price = 29.99 },
            new Product { Id = 11, Name = "Libro: Clean Architecture", Description = "De Robert C. Martin.", Price = 39.00 },
            new Product { Id = 12, Name = "Router Wi-Fi 6", Description = "Mayor velocidad y cobertura.", Price = 89.00 },
            new Product { Id = 13, Name = "Tablet 10\"", Description = "Ideal para leer y consumir contenido.", Price = 189.99 },
            new Product { Id = 14, Name = "Cámara Web HD", Description = "Perfecta para videollamadas.", Price = 49.90 },
            new Product { Id = 15, Name = "Disco Duro Externo 1TB", Description = "USB 3.0 de alta velocidad.", Price = 65.0 }
        );
    }
}