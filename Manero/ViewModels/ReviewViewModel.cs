

using Manero.Models.Entities;
using System;
using System.Collections.Generic;

namespace Manero.ViewModels
{
    public class ReviewViewModel
    {
        public int Rating { get; set; }
        public int ProductId { get; set; }
        public string CommentText { get; set; } = null!;
        public DateTime ReviewDate { get; set; }
        public string ProductName { get; set; } = null!;  
        public ProductEntity Product { get; set; } = null!;
        public List<ReviewEntity> Reviews { get; set; } = null!;
        public ICollection<ProductReviewEntity> ProductReviews { get; set; } = new List<ProductReviewEntity>();
    }

    public class ReviewEntry
    {

        public int Rating { get; set; }
        public int ProductId { get; set; }
        public string CommentText { get; set; } = null!;
    }
}
