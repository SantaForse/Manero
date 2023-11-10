using Manero.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Manero.Data;

public class ProductDbContext : DbContext
{

    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {
    }

    public DbSet <ProductEntity> Products { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<ProductCategoryEntity> ProductCategories { get; set; }


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
                },
                new ProductEntity
                {
                    ProductName = "Vit klänning",
                    Id = 2,
                    //CategoryId = 1, 
                    Description = "Handgjort vit klänning är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                    Rating = 2,
                    SalePrice = 500,
                    Price = 699,
                    ImageUrl = "https://images.pexels.com/photos/291759/pexels-photo-291759.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new ProductEntity
                {
                    ProductName = "Grön Hoodie",
                    Id = 3,
                    //CategoryId = 1, 
                    Description = "Handgjort vit hoodie är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                    Rating = 4,
                    SalePrice = 200,
                    Price = 299,
                    ImageUrl = "https://images.pexels.com/photos/981091/pexels-photo-981091.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                //New products
                new ProductEntity
                {
                    ProductName = "Brun Hoodie",
                    Id = 4,
                    //CategoryId = 1, 
                    Description = "Handgjort brun hoodie är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                    Rating = 5,
                    SalePrice = 200,
                    Price = 299,
                    ImageUrl = "https://images.pexels.com/photos/704857/pexels-photo-704857.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new ProductEntity
                {
                    ProductName = "Svart Hoodie",
                    Id = 5,
                    //CategoryId = 1, 
                    Description = "Handgjort svart hoodie är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                    Rating = 5,
                    Price = 299,
                    ImageUrl = "https://images.pexels.com/photos/744480/pexels-photo-744480.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new ProductEntity
                {
                    ProductName = "Grön klänning",
                    Id = 6,
                    //CategoryId = 1, 
                    Description = "Handgjort Grön klänning är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                    Rating = 4,
                    SalePrice = 200,
                    Price = 299,
                    ImageUrl = "https://images.pexels.com/photos/985635/pexels-photo-985635.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new ProductEntity
                {
                    ProductName = "Svarta skor",
                    Id = 7,
                    //CategoryId = 1, 
                    Description = "Handgjort svarta skor är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                    Rating = 3,
                    SalePrice = 200,
                    Price = 299,
                    ImageUrl = "https://images.pexels.com/photos/5214139/pexels-photo-5214139.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new ProductEntity
                {
                    ProductName = "Vita skor",
                    Id = 8,
                    //CategoryId = 1, 
                    Description = "Handgjort vita skor är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                    Rating = 2,
                    SalePrice = 200,
                    Price = 299,
                    ImageUrl = "https://images.pexels.com/photos/5730956/pexels-photo-5730956.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new ProductEntity
                {
                    ProductName = "Gula skor",
                    Id = 9,
                    //CategoryId = 1, 
                    Description = "Handgjort Gula skor är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                    Rating = 5,
                    SalePrice = 200,
                    Price = 299,
                    ImageUrl = "https://images.pexels.com/photos/2529157/pexels-photo-2529157.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new ProductEntity
                {
                    ProductName = "Bruna skor",
                    Id = 10,
                    //CategoryId = 1, 
                    Description = "Handgjort Bruna skor är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                    Rating = 3,
                    SalePrice = 200,
                    Price = 299,
                    ImageUrl = "https://images.pexels.com/photos/2562992/pexels-photo-2562992.png?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                });

        modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity
                {
                    Id = 1,
                    CategoryName = "Pants",
                },
                new CategoryEntity
                {
                    Id = 2,
                    CategoryName = "Accessories",
                },
                new CategoryEntity
                {
                    Id = 3,
                    CategoryName = "Shoes",
                },
                new CategoryEntity
                {
                    Id = 4,
                    CategoryName = "T-shirts",
                },
                new CategoryEntity
                {
                    Id = 5,
                    CategoryName = "Dresses",
                },
                new CategoryEntity
                {
                    Id = 6,
                    CategoryName = "Hoodie",
                });

        modelBuilder.Entity<ProductCategoryEntity>().HasData(
                new ProductCategoryEntity
                {
                    ProductId = 1,
                    CategoryId = 2,
                },
                new ProductCategoryEntity
                {
                    ProductId = 2,
                    CategoryId = 5,
                },
                new ProductCategoryEntity
                {
                    ProductId = 3,
                    CategoryId = 2,
                },
                new ProductCategoryEntity
                {
                    ProductId = 6,
                    CategoryId = 5,
                },
                new ProductCategoryEntity
                {
                    ProductId = 7,
                    CategoryId = 3,
                },
                new ProductCategoryEntity
                {
                    ProductId = 8,
                    CategoryId = 3,
                },
                new ProductCategoryEntity
                {
                    ProductId = 9,
                    CategoryId = 3,
                },
                new ProductCategoryEntity
                {
                    ProductId = 10,
                    CategoryId = 3,
                },
                new ProductCategoryEntity
                {
                    ProductId = 8,
                    CategoryId = 2,
                },
                new ProductCategoryEntity
                {
                    ProductId = 9,
                    CategoryId = 2,
                },
                new ProductCategoryEntity
                {
                    ProductId = 10,
                    CategoryId = 2,
                },
                new ProductCategoryEntity
                {
                    ProductId = 5,
                    CategoryId = 6,
                },
                new ProductCategoryEntity
                {
                    ProductId = 4,
                    CategoryId = 6,
                },
                new ProductCategoryEntity
                {
                    ProductId = 3,
                    CategoryId = 6,
                });
            }
                
}



