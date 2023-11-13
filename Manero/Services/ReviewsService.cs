using Manero.Data;
using Manero.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Manero.Services
{
    public class ReviewsService : ProductsService
    {
        protected ProductDbContext _context;

        public ReviewsService(ProductDbContext context) : base(context)
        {
            _context = context;
        }

      

        public ProductEntity GetProductByName(string productName)
        {
            return _context.Products.FirstOrDefault(p => p.ProductName == productName);
        }

        public IEnumerable<ReviewEntity> GetReviews(int productId)
        {
            return _context.ProductReviews
                .Where(pr => pr.ProductId == productId)
                .Select(pr => pr.Review)
                .ToList();
        }
    }
}
