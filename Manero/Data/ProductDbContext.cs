using Manero.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Manero.Data;

public class ProductDbContext : DbContext
{

    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {
    }

    public DbSet <ProductEntity> Products { get; set; }

    //Static example product
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity
                {
                    ProductName = "Skägg deluxe",
                    Id = 1,
                    //CategoryId = 1, 
                    Description = "Handgjort ansiktsskägg är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                    Rating = 3,
                    SalePrice = 300,
                    Price = 399,
                    ImageUrl = "https://media.discordapp.net/attachments/1161545688103006245/1171425219949371442/tactical-beard-brown.png?ex=655ca1c0&is=654a2cc0&hm=44c37be70087bceccb4e1e8b29418f640271e6e32984398ca58d349ba8aeb131&=&width=337&height=368"
                });
    }
                
}



