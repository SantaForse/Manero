using System.ComponentModel.DataAnnotations;

namespace Manero.Models.Entities
{
    public class ReviewEntity
    {

        public int Id { get; set; }
        public int Rating { get; set; }
        public string CommentText { get; set; } = null!;
        public DateTime ReviewDate { get; set; }

        public ICollection<ProductReviewEntity> ProductReviws { get; set; } = new List<ProductReviewEntity>();
    }
}

