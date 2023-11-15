using Manero.Data;
using Manero.Models.Entities;
using Manero.Services;
using Microsoft.EntityFrameworkCore;

namespace Manero.Tests;

// These are Zahra's tests, more tests will be added for reviews part
public class ProductServiceTests
{


    [Fact]
    public void ToGet_Reviews_From_Database()
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
                    Rating = 3,
                    CommentText = "Good",
                    ReviewDate = DateTime.Now
                },
                new ReviewEntity
                {
                    Rating = 1,
                    CommentText = "Bad",
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






    [Fact]
    public void ToGet_ReviewsFor_SpecificProduct()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<ProductDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        using (var context = new ProductDbContext(options))
        {
            var product = new ProductEntity
            {
                ProductName = "MyTestProduct",
                Description = "This product is very nice but this is for test now.",
                Rating = 5,
                Price = 70,
                SalePrice = 40,
                ImageUrl = "https://testForproduct.com/image.jpg",

            };

            var review1 = new ReviewEntity
            {
                Rating = 5,
                CommentText = "Nice",
                ReviewDate = DateTime.Now
            };

            var review2 = new ReviewEntity
            {
                Rating = 4,
                CommentText = "Good",
                ReviewDate = DateTime.Now
            };

            context.Products.Add(product);
            context.Reviews.AddRange(review1, review2);

            var productReview1 = new ProductReviewEntity { ProductId = product.Id, ReviewId = review1.Id };
            var productReview2 = new ProductReviewEntity { ProductId = product.Id, ReviewId = review2.Id };

            context.ProductReviews.AddRange(productReview1, productReview2);

            context.SaveChanges();
        }

        using (var context = new ProductDbContext(options))
        {
            var productService = new ProductsService(context);
            var reviewService = new ReviewService(context, productService);


            var product = context.Products.Single(p => p.ProductName == "TestProduct");
            var reviews = reviewService.GetReviews(product.Id);

            // Assert
            Assert.NotNull(reviews);
            Assert.Equal(2, reviews.Count());
        }
    }


}
