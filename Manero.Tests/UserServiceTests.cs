/*
using manero.Data;
using Manero.Data;
using Manero.Models.Entities;
using Manero.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manero.Tests
{
    public class UserServiceTests
    {
        [Fact] //Test if Promo Codes associated with a specific user by user id are retrieved from database
        public async Task hjgkjh()
        {
            // Arrange
            var applicationDbOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "Users_Database")
                .Options;

            var productDbOptions = new DbContextOptionsBuilder<ProductDbContext>()
                .UseInMemoryDatabase(databaseName: "Products_Database")
                .Options;


            using (var _userContext = new ApplicationDbContext(applicationDbOptions))
            {
                // Add two test users to the in-memory database
                _userContext.Users.Add(new IdentityUser
                {
                    Id = "5ebe6c4c-409c-47fe-bed4-df34cdbd3a8a",
                    UserName = "hans@maneromail.com"
                });
                _userContext.Users.Add(new IdentityUser
                {
                    Id = "a106762b-162f-4e96-9c50-8f6b80298fd1",
                    UserName = "tommy@maneromail.com"
                });
                _userContext.SaveChanges();


                using (var _productContext = new ProductDbContext(productDbOptions))
            {
                    _productContext.PromoCodes.Add(new PromoCodeEntity
                    {
                        Id = 1,
                        ImageUrl = "/static-images/placeholder_promocode.svg",
                        Title = "Acme Co.",
                        Discount = 50,
                        ExpirationDate = "June 1, 2024",
                    });
                    _productContext.PromoCodes.Add(new PromoCodeEntity
                    {
                        Id = 2,
                        ImageUrl = "/static-images/placeholder_promocode.svg",
                        Title = "Barone LLC.",
                        Discount = 30,
                        ExpirationDate = "May 1, 2022",
                    });
                _productContext.PromoCodes.Add(new PromoCodeEntity
                {
                    Id = 3,
                    ImageUrl = "/static-images/placeholder_promocode.svg",
                    Title = "Abstergo Ltd.",
                    Discount = 15,
                    ExpirationDate = "June 30, 2022",
                });
                _productContext.SaveChanges();







            }

            using (var context = new ProductDbContext(options))
            {
                var service = new TagsService(context);

                // Act
                var result = await service.GetProducts();

                // Assert
                Assert.NotNull(result);
                Assert.Equal(2, result.Count()); // Check the expected number of products
                Assert.Contains(result, p => p.ProductName == "Product1"); // Check for a specific product
                Assert.Contains(result, p => p.ProductName == "Product2"); // Check for another specific product
            }
        }
    }
}
*/