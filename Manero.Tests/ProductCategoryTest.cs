
using Manero.Data;
using Manero.Models.Entities;
using Manero.Services;
using Microsoft.EntityFrameworkCore;

namespace Manero.Tests
{
    // Test by Sami
    //Jag gör test för navigering och category


    public class ProductCategoryTest : IClassFixture<CustomWebApplicationFactory>
    {

        private readonly HttpClient _client;

        public ProductCategoryTest(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }


        [Fact]
        public async Task DressesPageShouldReturnSuccess()
        {
            var response = await _client.GetAsync("/Category/Dresses");
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task PantsPageShouldReturnSuccess()
        {
            var response = await _client.GetAsync("/Category/Pants");
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task ShoesPageShouldReturnSuccess()
        {
            var response = await _client.GetAsync("/Category/Shoes");
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task HoodiePageShouldReturnSuccess()
        {
            var response = await _client.GetAsync("/Category/Hoodie");
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task AccessoriesPageShouldReturnSuccess()
        {
            var response = await _client.GetAsync("/Category/Accessories");
            response.EnsureSuccessStatusCode();
        }



        [Fact]
        public void PantsCategory_ReturnsPants()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ProductDbContext>()
                .UseInMemoryDatabase(databaseName: "PantsCategory_ReturnsPants_Database")
                .Options;

            using (var context = new ProductDbContext(options))
            {
                // Adding category to db
                context.Categories.Add(new CategoryEntity { CategoryName = "Pants" });
                context.SaveChanges();
            }

            using (var context = new ProductDbContext(options))
            {
                var service = new ProductsService(context);

                // Act
                var result = service.GetAllCategories();

                // Assert
                Assert.NotNull(result);

                //Seeing if the db has this category
                Assert.Single(result);
                Assert.Contains(result, p => p.CategoryName == "Pants");
            }
        }



        [Fact]
        public void AccessoriesCategory_ReturnsAccessories()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ProductDbContext>()
                .UseInMemoryDatabase(databaseName: "AccessoriesCategory_ReturnsAccessories_Database")
                .Options;

            using (var context = new ProductDbContext(options))
            {
                // Adding category to db
                context.Categories.Add(new CategoryEntity { CategoryName = "Accessories" });
                context.SaveChanges();
            }

            using (var context = new ProductDbContext(options))
            {
                var service = new ProductsService(context);

                // Act
                var result = service.GetAllCategories();

                // Assert
                Assert.NotNull(result);

                //Seeing if the db has this category
                Assert.Single(result);
                Assert.Contains(result, p => p.CategoryName == "Accessories");
            }
        }



        [Fact]
        public void ShoesCategory_ReturnsShoes()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ProductDbContext>()
                .UseInMemoryDatabase(databaseName: "ShoesCategory_ReturnsShoes_Database")
                .Options;

            using (var context = new ProductDbContext(options))
            {
                // Adding category to db
                context.Categories.Add(new CategoryEntity { CategoryName = "Shoes" });
                context.SaveChanges();
            }

            using (var context = new ProductDbContext(options))
            {
                var service = new ProductsService(context);

                // Act
                var result = service.GetAllCategories();

                // Assert
                Assert.NotNull(result);

                //Seeing if the db has this category
                Assert.Single(result);
                Assert.Contains(result, p => p.CategoryName == "Shoes");
            }
        }



        [Fact]
        public void TshirtsCategory_ReturnsTshirts()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ProductDbContext>()
                .UseInMemoryDatabase(databaseName: "TshirtsCategory_ReturnsTshirts_Database")
                .Options;

            using (var context = new ProductDbContext(options))
            {
                // Adding category to db
                context.Categories.Add(new CategoryEntity { CategoryName = "T-shirts" });
                context.SaveChanges();
            }

            using (var context = new ProductDbContext(options))
            {
                var service = new ProductsService(context);

                // Act
                var result = service.GetAllCategories();

                // Assert
                Assert.NotNull(result);

                //Seeing if the db has this category
                Assert.Single(result);
                Assert.Contains(result, p => p.CategoryName == "T-shirts");
            }
        }



        [Fact]
        public void DressesCategory_ReturnsDresses()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ProductDbContext>()
                .UseInMemoryDatabase(databaseName: "DressesCategory_ReturnsDresses_Database")
                .Options;

            using (var context = new ProductDbContext(options))
            {
                // Adding category to db
                context.Categories.Add(new CategoryEntity { CategoryName = "Dresses" });
                context.SaveChanges();
            }

            using (var context = new ProductDbContext(options))
            {
                var service = new ProductsService(context);

                // Act
                var result = service.GetAllCategories();

                // Assert
                Assert.NotNull(result);

                //Seeing if the db has this category
                Assert.Single(result);
                Assert.Contains(result, p => p.CategoryName == "Dresses");
            }
        }




        [Fact]
        public void HoodieCategory_ReturnsHoodie()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ProductDbContext>()
                .UseInMemoryDatabase(databaseName: "HoodieCategory_ReturnsHoodie_Database")
                .Options;

            using (var context = new ProductDbContext(options))
            {
                // Adding category to db
                context.Categories.Add(new CategoryEntity { CategoryName = "Hoodie" });
                context.SaveChanges();
            }

            using (var context = new ProductDbContext(options))
            {
                var service = new ProductsService(context);

                // Act
                var result = service.GetAllCategories();

                // Assert
                Assert.NotNull(result);

                //Seeing if the db has this category
                Assert.Single(result);
                Assert.Contains(result, p => p.CategoryName == "Hoodie");
            }
        }

    }
}
