using Manero.Data;
using Manero.Models.Entities;
using Manero.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manero.Tests;

public class ProductServiceTests
{
    //Jag skapar en testfil för productService - Jeppe


    //Testing "GetProducts" 
    [Fact]
    public void GetProducts_ReturnsAllProducts()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<ProductDbContext>()
            .UseInMemoryDatabase(databaseName: "GetProducts_ReturnsAllProducts_Database")
            .Options;

        using (var context = new ProductDbContext(options))
        {
            // Adding products to db
            context.Products.Add(new ProductEntity { ProductName = "Product1", ImageUrl = "", Price = 3 });
            context.Products.Add(new ProductEntity { ProductName = "Product2", ImageUrl = "", Price = 3 });
            context.SaveChanges();
        }

        using (var context = new ProductDbContext(options))
        {
            var service = new ProductsService(context);

            // Act
            var result = service.GetProducts();

            // Assert
            Assert.NotNull(result);

            //Seeing if the db has the products
            Assert.Equal(2, result.Count()); 
            Assert.Contains(result, p => p.ProductName == "Product1");
            Assert.Contains(result, p => p.ProductName == "Product2"); 
        }
    }


    //Testing "GetCategories" Enligt Userstory MG1-139 av Jesper
    [Fact]
    public void GetCategories_ReturnsAllCategories()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<ProductDbContext>()
            .UseInMemoryDatabase(databaseName: "GetCategories_ReturnsAllCategories_Database")
            .Options;

        using (var context = new ProductDbContext(options))
        {
            // Adding categories to db
            context.Categories.Add(new CategoryEntity { CategoryName = "Category1"  });
            context.Categories.Add(new CategoryEntity { CategoryName = "Category2" });
            context.SaveChanges();
        }

        using (var context = new ProductDbContext(options))
        {
            var service = new ProductsService(context);

            // Act
            var result = service.GetAllCategories();

            // Assert
            Assert.NotNull(result);

            //Seeing if the db has the categories
            Assert.Equal(2, result.Count()); 
            Assert.Contains(result, p => p.CategoryName == "Category1"); 
            Assert.Contains(result, p => p.CategoryName == "Category2"); 
        }
    }


    //Testing "GetProductsByCategory" Enligt Userstory MG1-16 av Jesper
    [Fact]
    public void GetProductsByCategory_ReturnsProductsForCategory()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<ProductDbContext>()
            .UseInMemoryDatabase(databaseName: "GetProductsByCategory_Database")
            .Options;

        using (var context = new ProductDbContext(options))
        {
            // Adding data to db
            var category = new CategoryEntity { CategoryName = "Shoes", Id = 1 };
            context.Categories.Add(category);
            
            context.Products.Add(new ProductEntity { ProductName = "Black shoes", ImageUrl = "", Price = 3, Id = 1 });
            context.Products.Add(new ProductEntity { ProductName = "Blue shoes", ImageUrl = "", Price = 3, Id = 2 });
            context.Products.Add(new ProductEntity { ProductName = "Brown shoes", ImageUrl = "", Price = 3, Id = 3 }); 
            
            //Connects the first two products to a category
            context.ProductCategories.Add(new ProductCategoryEntity { CategoryId = 1, ProductId = 1 });
            context.ProductCategories.Add(new ProductCategoryEntity { CategoryId = 1, ProductId = 2 });

            context.SaveChanges();
        }

        using (var context = new ProductDbContext(options))
        {
            var service = new ProductsService(context);

            // Act
            var result = service.GetProductsByCategory("Shoes");

            // Assert
            Assert.NotNull(result);

            // Looks to see if the right amount of products show, (should be
            // two, since the third doesnt have a category)
            Assert.Equal(2, result.Count()); 
            Assert.Contains(result, p => p.ProductName == "Black shoes"); 
            Assert.Contains(result, p => p.ProductName == "Blue shoes"); 
        }
    }

    //Testing "GetProductsByCategory" 
    [Fact]
    public void GetCategoriesForProduct_ReturnsCategoriesForProduct()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<ProductDbContext>()
            .UseInMemoryDatabase(databaseName: "GetProductsByCategory_Database")
            .Options;

        using (var context = new ProductDbContext(options))
        {
            // Adding data to db
            context.Categories.Add(new CategoryEntity { CategoryName = "Shoes", Id = 1 });
            context.Categories.Add(new CategoryEntity { CategoryName = "Sandals", Id = 2 });
            context.Categories.Add(new CategoryEntity { CategoryName = "Sneakers", Id = 3 });
            context.Categories.Add(new CategoryEntity { CategoryName = "Soft soles", Id = 4 });

            context.Products.Add(new ProductEntity { ProductName = "Black sandals", ImageUrl = "", Price = 3, Id = 1 });
            context.Products.Add(new ProductEntity { ProductName = "Blue Sneakers", ImageUrl = "", Price = 3, Id = 2 });
            context.Products.Add(new ProductEntity { ProductName = "Brown shoes", ImageUrl = "", Price = 3, Id = 3 });

            //Connects the first two products to a category
            context.ProductCategories.Add(new ProductCategoryEntity { CategoryId = 1, ProductId = 1 });
            context.ProductCategories.Add(new ProductCategoryEntity { CategoryId = 1, ProductId = 2 });
            context.ProductCategories.Add(new ProductCategoryEntity { CategoryId = 2, ProductId = 1 });
            context.ProductCategories.Add(new ProductCategoryEntity { CategoryId = 3, ProductId = 2 });
            context.ProductCategories.Add(new ProductCategoryEntity { CategoryId = 4, ProductId = 2 });


            context.SaveChanges();
        }

        using (var context = new ProductDbContext(options))
        {
            var service = new ProductsService(context);

            // Act
            var result = service.GetCategoriesForProduct("Blue Sneakers");

            // Assert
            Assert.NotNull(result);

            // Looks to see if the right amount of products show, 
            Assert.Equal(3, result.Count());
            //Can check if specifik categories are in that list
            Assert.Contains(result, p => p.CategoryName == "Shoes");
            Assert.Contains(result, p => p.CategoryName == "Sneakers");
        }
    }
}
