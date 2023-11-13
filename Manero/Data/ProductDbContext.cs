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

    public DbSet<PromoCodeEntity> PromoCodes { get; set; }
    public DbSet<UserPromoCodeEntity> UserPromoCodes { get; set; }




    //Static example product
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {




        #region pre seeding promo codes data
        
        modelBuilder.Entity<PromoCodeEntity>().HasData(
            new PromoCodeEntity
            {
                Id = 1,
                ImageUrl = "/static-images/placeholder_promocode.svg",
                Title = "Acme Co.",
                Discount = 50,
                ExpirationDate = "June 1, 2024",
            },
            new PromoCodeEntity
            {
                Id = 2,
                ImageUrl = "/static-images/placeholder_promocode.svg",
                Title = "Barone LLC.",
                Discount = 30,
                ExpirationDate = "May 1, 2022",
            },
            new PromoCodeEntity
            {
                Id = 3,
                ImageUrl = "/static-images/placeholder_promocode.svg",
                Title = "Abstergo Ltd.",
                Discount = 15,
                ExpirationDate = "June 30, 2022",
            });
        
            modelBuilder.Entity<UserPromoCodeEntity>().HasData(
            new UserPromoCodeEntity
            {
                UserId = "5ebe6c4c-409c-47fe-bed4-df34cdbd3a8a",
                PromoCodeId = 1,
            },
            new UserPromoCodeEntity
            {
                UserId = "a106762b-162f-4e96-9c50-8f6b80298fd1",
                PromoCodeId =  2,
            },
            new UserPromoCodeEntity
            {
                UserId = "a106762b-162f-4e96-9c50-8f6b80298fd1",
                PromoCodeId = 3,
            });

        #endregion
    }
}
                




