using Manero.Controllers;
using Manero.Data;
using Manero.Models.Entities;
using Manero.Services;
using Manero.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Manero.Tests
{
    // These are Zahra's tests
    public class ReviewsServiceTests
    {
        [Fact]
        public void ToGet_Reviews_From_Database()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ProductDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using (var _context = new ProductDbContext(options))
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

                _context.Reviews.AddRange(reviews);
                _context.SaveChanges();
            }

            using (var _context = new ProductDbContext(options))
            {
                // Act
                var reviewsFromDb = _context.Reviews.ToList();

                // Assert
                Assert.NotNull(reviewsFromDb);
                Assert.Equal(3, reviewsFromDb.Count);
            }
        }

        [Fact]
        public void ToGet_ReviewsFor_SpecificProduct()
        {

            var options = new DbContextOptionsBuilder<ProductDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using (var _context = new ProductDbContext(options))
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

                _context.Products.Add(product);
                _context.Reviews.AddRange(review1, review2);

                var productReview1 = new ProductReviewEntity { ProductId = product.Id, ReviewId = review1.Id };
                var productReview2 = new ProductReviewEntity { ProductId = product.Id, ReviewId = review2.Id };

                _context.ProductReviews.AddRange(productReview1, productReview2);

                _context.SaveChanges();
            }

            using (var _context = new ProductDbContext(options))
            {
                var productService = new ProductsService(_context);
                var reviewService = new ReviewService(_context, productService);


                var product = _context.Products.SingleOrDefault(p => p.ProductName == "MyTestProduct");


                Assert.NotNull(product);
                var reviews = reviewService.GetReviews(product.Id);


                Assert.NotNull(reviews);
                Assert.Equal(2, reviews.Count());
            }


        }
            [Fact]
            public void AddReview_To_product()
            {
            
                var options = new DbContextOptionsBuilder<ProductDbContext>()
                    .UseInMemoryDatabase(databaseName: "AddReview_ReviewAddedSuccessfully")
                    .Options;

                using (var context = new ProductDbContext(options))
                {
                    var productService = new ProductsService(context);
                    var reviewService = new ReviewService(context, productService);

                    
                    var product = new ProductEntity
                    {
                        ProductName = "Skor",
                        ImageUrl = "testpic.jpg",
                        
                    };

                    context.Products.Add(product);
                    context.SaveChanges();

                    var review = new ReviewEntity
                    {
                        Rating = 5,
                        CommentText = "good"
                    };

                    // Act
                    reviewService.AddReview(review, product.Id);
                }

             
                using (var context = new ProductDbContext(options))
                {
                   
                    Assert.Single(context.Reviews);

                   
                    var addedReview = context.Reviews.Single();
                    Assert.Equal(5, addedReview.Rating);
                    Assert.Equal("good", addedReview.CommentText);
                }
            }


            [Fact]
         public void ToAddReview_ToInvalidProductId_ReviewCanNotBeAdded()
        {
         
            var options = new DbContextOptionsBuilder<ProductDbContext>()
                .UseInMemoryDatabase(databaseName: "AddReview_InvalidProductId")
                .Options;

            using (var context = new ProductDbContext(options))
            {
                var productId = 1;
                var review = new ReviewEntity
                {
                    Rating = 5,
                    CommentText = "good"
                };

                var productService = new ProductsService(context);
                var reviewService = new ReviewService(context, productService);

               
                reviewService.AddReview(review, productId);
            }

        
            using (var context = new ProductDbContext(options))
            {
                Assert.Equal(0, context.Reviews.Count()); 
                Assert.Equal(0, context.ProductReviews.Count());
            }
        }
    }

}







