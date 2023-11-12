using Manero.Data;
using Manero.Models.Entities;
using Manero.Services;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Manero.Tests;

public class TagsServiceTests
{
    [Fact]
    public async Task GetProducts_ReturnsAllProducts()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<ProductDbContext>()
            .UseInMemoryDatabase(databaseName: "GetProducts_ReturnsAllProducts_Database")
            .Options;

        using (var context = new ProductDbContext(options))
        {
            // Add some test products to the in-memory database
            context.Products.Add(new ProductEntity { ProductName = "Product1", ImageUrl = "", Price = 3 });
            context.Products.Add(new ProductEntity { ProductName = "Product2", ImageUrl = "", Price = 3 });
            context.SaveChanges();
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

    [Fact]
    public async Task GetNewProducts_ReturnsTop10NewestProducts()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<ProductDbContext>()
            .UseInMemoryDatabase(databaseName: "GetNewProducts_ReturnsTop10NewestProducts_Database")
            .Options;

        using (var context = new ProductDbContext(options))
        {
            // Add test products to the in-memory database with sequential IDs
            for (int i = 15; i >= 6; i--)
            {
                context.Products.Add(new ProductEntity { Id = i, ProductName = $"Product{i}", ImageUrl = "", Price = 3 });
            }

            context.SaveChanges();

            var service = new TagsService(context);

            // Act
            var result = await service.GetNewProducts();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(10, result.Count()); // Check the expected number of products
            Assert.True(result.Select(p => p.ProductName).SequenceEqual(new[] { "Product15", "Product14", "Product13", "Product12", "Product11", "Product10", "Product9", "Product8", "Product7", "Product6" }));
        }
    }


    [Fact]
    public async Task GetSaleProducts_ReturnsProductsOnSale()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<ProductDbContext>()
            .UseInMemoryDatabase(databaseName: "GetSaleProducts_ReturnsProductsOnSale_Database")
            .Options;

        using (var context = new ProductDbContext(options))
        {
            // Add some test products to the in-memory database
            context.Products.Add(new ProductEntity { ProductName = "Product1", ImageUrl = "", Price = 3, SalePrice = 2 });
            context.Products.Add(new ProductEntity { ProductName = "Product2", ImageUrl = "", Price = 3 });
            context.Products.Add(new ProductEntity { ProductName = "Product3", ImageUrl = "", Price = 3, SalePrice = 2 });
           
         
            context.SaveChanges();

        }

        using (var context = new ProductDbContext(options))
        {
            var service = new TagsService(context);

            // Act
            var result = await service.GetSaleProducts();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count()); // Check the expected number of products on sale
            Assert.Contains(result, p => p.ProductName == "Product1"); // Check for a specific product on sale
            Assert.Contains(result, p => p.ProductName == "Product3"); // Check for another specific product on sale
        }
    }

    [Fact]
    public async Task GetTopProducts_ReturnsTop10RatedProducts()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<ProductDbContext>()
            .UseInMemoryDatabase(databaseName: "GetTopProducts_ReturnsTop10RatedProducts_Database")
            .Options;

        using (var context = new ProductDbContext(options))
        {
            // Add some test products to the in-memory database
            // Assuming products have descending Ratings for simplicity
            for (int i = 1; i <= 15; i++)
            {
                context.Products.Add(new ProductEntity { ProductName = $"Product{i}", ImageUrl = "", Price = 3, Rating = i });
            }

            context.SaveChanges();
        }

        using (var context = new ProductDbContext(options))
        {
            var service = new TagsService(context);

            // Act
            var result = await service.GetTopProducts();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(10, result.Count()); // Check the expected number of top-rated products
            Assert.True(result.OrderByDescending(p => p.Rating).Select(p => p.ProductName).SequenceEqual(new[] { "Product15", "Product14", "Product13", "Product12", "Product11", "Product10", "Product9", "Product8", "Product7", "Product6" }));
        }
    }



    [Fact]
    public void GetTag_CaseInsensitiveSearch_ShouldReturnTag()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<ProductDbContext>()
            .UseInMemoryDatabase(databaseName: "GetProducts_ReturnsAllProducts_Database")
            .Options;

        using (var context = new ProductDbContext(options))
        {
            // Add some test products to the in-memory database
            context.Products.Add(new ProductEntity { ProductName = "Product1", ImageUrl = "", Price = 3 });
            context.Products.Add(new ProductEntity { ProductName = "Product2", ImageUrl = "", Price = 3 });
            context.SaveChanges();
        }

        using (var context = new ProductDbContext(options))
        {
            var tagService = new TagsService(context);

            // Act
            var result1 = tagService.GetTag("Sale");
            var result2 = tagService.GetTag("sAlE");
            var result3 = tagService.GetTag("new");

            // Assert
            Assert.Equal("Sale", result1);
            Assert.Equal("Sale", result2);
            Assert.Equal("New", result3);

        }
    }

   

}