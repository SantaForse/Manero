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

    

        public void AddReview(ReviewEntity review, int productId)
        {
            review.ReviewDate = DateTime.Now;

            var product = _productsService.GetProductById(productId);

            if (product != null)
            {

                _context.Reviews.Add(review);
                _context.SaveChanges();

                var productReview = new ProductReviewEntity
                {
                    ProductId = product.Id,
                    ReviewId = review.Id
                };

                _context.ProductReviews.Add(productReview);
                _context.SaveChanges();
            }
            else
            {
              
            }
        }
    }
}





//public void AddReviewToProduct(ProductEntity product, ReviewEntity review)
//{
//    var productReview = new ProductReviewEntity
//    {
//        ProductId = product.Id,
//        ReviewId = review.Id
//    };

//    _context.ProductReviews.Add(productReview);
//    _context.SaveChanges();
//}













