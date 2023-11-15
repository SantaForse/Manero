using Manero.Data;
using Manero.Models.Entities;
using Manero.Services;
using Microsoft.EntityFrameworkCore;

namespace Manero.Services
{
    public class ReviewService
    {
        private readonly ProductDbContext _context;
        private readonly ProductsService _productsService;

        public ReviewService(ProductDbContext context, ProductsService productsService)
        {
            _context = context;
            _productsService = productsService;
        }

        public IEnumerable<ReviewEntity> GetReviews(int productId)
        {
            return _context.ProductReviews
                .Where(pr => pr.ProductId == productId)
                .Select(pr => pr.Review)
                .ToList();
        }

        public void AddReviewToProduct(ProductEntity product, ReviewEntity review)
        {
            var productReview = new ProductReviewEntity
            {
                ProductId = product.Id,
                ReviewId = review.Id
            };

            _context.ProductReviews.Add(productReview);
            _context.SaveChanges();
        }
    }
}


//    public void AddReview(ReviewEntity review, int productId)
//    {
//        review.ReviewDate = DateTime.Now;

//        var product = productsService.GetProductById(productId);

//        if (product != null)
//        {
//            var productReview = new ProductReviewEntity
//            {
//                ProductId = product.Id,
//                ReviewId = review.Id
//            };

//            dbContext.Reviews.Add(review);
//            dbContext.ProductReviews.Add(productReview);
//            dbContext.SaveChanges();
//        }
//        else
//        {
//            // Handle the case where the product doesn't exist
//        }
//    }
//}
















//using Manero.Data;
//using Manero.Models.Entities;
//using Microsoft.EntityFrameworkCore;
//using System.Collections.Generic;
//using System.Linq;

//namespace Manero.Services
//{
//    public class ReviewsService : ProductsService
//    {
//        protected ProductDbContext _context;

//        public ReviewsService(ProductDbContext context) : base(context)
//        {
//            _context = context;
//        }



//        public ProductEntity GetProductByName(string productName)
//        {
//            return _context.Products.FirstOrDefault(p => p.ProductName == productName);
//        }

//        public IEnumerable<ReviewEntity> GetReviews(int productId)
//        {
//            return _context.ProductReviews
//                .Where(pr => pr.ProductId == productId)
//                .Select(pr => pr.Review)
//                .ToList();
//        }
//    }
//}
