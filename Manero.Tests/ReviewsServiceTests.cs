using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Manero.Data;
using Manero.Models.Entities;
using Microsoft.EntityFrameworkCore.InMemory;
using Xunit;
using System.Linq;

// These are Zahra's tests, more tests will be added for reviews part
public class ProductReviewEntity
{
    [Fact]
    public void Get_Reviews_From_Database()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<ProductDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        using (var context = new ProductDbContext(options))
        {
            
            var reviews = new List<ReviewEntity>
            {
                new ReviewEntity
                {
                    Rating = 5,
                    CommentText = "Excellent",
                    ReviewDate = DateTime.Now
                },
                new ReviewEntity
                {
                    Rating = 4,
                    CommentText = "Good",
                    ReviewDate = DateTime.Now
                },
                new ReviewEntity
                {
                    Rating = 3,
                    CommentText = "Okay",
                    ReviewDate = DateTime.Now
                }
            };

            context.Reviews.AddRange(reviews);
            context.SaveChanges();
        }

        using (var context = new ProductDbContext(options))
        {
            // Act
            var reviewsFromDb = context.Reviews.ToList();

            // Assert
            Assert.NotNull(reviewsFromDb);
            Assert.Equal(3, reviewsFromDb.Count); 
        }
    }
}


//Test to get avarage Ratings star for en speciel product

//more tests will be added for reviews part