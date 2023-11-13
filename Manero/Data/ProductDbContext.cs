using Manero.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Manero.Data;

public class ProductDbContext : DbContext
{

    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {
    }

    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<ProductCategoryEntity> ProductCategories { get; set; }

    public DbSet<ReviewEntity> Reviews { get; set; }
    public DbSet<ProductReviewEntity> ProductReviews { get; set; }

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


        modelBuilder.Entity<ReviewEntity>().HasData(
        new ReviewEntity
        {
            Id = 1,
            Rating = 5,
            CommentText = "Excellent.I highly recommend this business",
            ReviewDate = DateTime.Now,
        },
        new ReviewEntity
        {
            Id = 2,
            Rating = 4,
            CommentText = "Nice,I was completely impressed with their professionalism and customer service",
            ReviewDate = DateTime.Now,
        },
        new ReviewEntity
        {
            Id = 3,
            Rating = 3,
            CommentText = "Thanks so much, I am very happy with my purchase",
            ReviewDate = DateTime.Now,
        }, new ReviewEntity
        {
            Id = 4,
            Rating = 2,
            CommentText = "Not bad, It could have been of better quality",
            ReviewDate = DateTime.Now,
        },
        new ReviewEntity
        {
            Id = 5,
            Rating = 5,
            CommentText = "Eexellent, It has good quality",
            ReviewDate = DateTime.Now,
        },
        new ReviewEntity
        {
            Id = 6,
            Rating = 3,
            CommentText = "That was OK",
            ReviewDate = DateTime.Now,
        },
        new ReviewEntity
        {
            Id = 7,
            Rating = 5,
            CommentText = "Very good, and good quality",
            ReviewDate = DateTime.Now,
        }, new ReviewEntity
        {
            Id = 8,
            Rating = 1,
            CommentText = "Vey Bad, I am not satisfied at all",
            ReviewDate = DateTime.Now,
        },
        new ReviewEntity
        {
            Id = 9,
            Rating = 5,
            CommentText = "Eexellent .Thanks so much, I am very happy with my purchase",
            ReviewDate = DateTime.Now,
        },
        new ReviewEntity
        {
            Id = 10,
            Rating = 3,
            CommentText = "Nice ,I am very happy",
            ReviewDate = DateTime.Now,
        });



        modelBuilder.Entity<ProductReviewEntity>().HasData(
           new ProductReviewEntity
           {
               ProductId = 1,
               ReviewId = 1,
           },

           new ProductReviewEntity
           {
               ProductId = 1,
               ReviewId = 2,
           },
             new ProductReviewEntity
             {
                 ProductId = 1,
                 ReviewId = 7,
             },
            new ProductReviewEntity
            {
                ProductId = 1,
                ReviewId = 10,
            },
            new ProductReviewEntity
            {
                ProductId = 1,
                ReviewId = 9,
            },

            new ProductReviewEntity
            {
                ProductId = 2,
                ReviewId = 4,
            },

            new ProductReviewEntity
            {
                ProductId = 2,
                ReviewId = 5,
            },

            new ProductReviewEntity
            {
                ProductId = 2,
                ReviewId = 3,
            },

            new ProductReviewEntity
            {
                ProductId = 3,
                ReviewId = 5,
            },
            new ProductReviewEntity
            {
                ProductId = 4,
                ReviewId = 6,
            },

            new ProductReviewEntity
            {
                ProductId = 5,
                ReviewId = 7,
            },

            new ProductReviewEntity
            {
                ProductId = 6,
                ReviewId = 8,
            },
            new ProductReviewEntity
            {
                ProductId = 7,
                ReviewId = 10,
            },
            new ProductReviewEntity
            {
                ProductId = 8,
                ReviewId = 9,
            },

            new ProductReviewEntity
            { 
                ProductId = 9,
                ReviewId = 10,
            },

            new ProductReviewEntity
            {
                ProductId = 10,
                ReviewId = 2,
            });

    }
}


