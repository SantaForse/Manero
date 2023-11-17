using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Entities
{
    [PrimaryKey(nameof(ProductId), nameof(ReviewId))]
    public class ProductReviewEntity
    {
        public int ReviewId { get; set; }
        public int ProductId { get; set; }

        public ProductEntity Product { get; set; } = null!;
        public ReviewEntity Review { get; set; } = null!;
    }
}


//using Microsoft.EntityFrameworkCore;

//namespace Manero.Models.Entities
//{
//    [PrimaryKey(nameof(ProductId), nameof(ReviewId), nameof(UserId))]
//    public class ProductReviewEntity
//    {
//        public int ReviewId { get; set; }
//        public int ProductId { get; set; }
//        public int UserId { get; set; }
//   

//        public ProductEntity Product { get; set; } = null!;
//        public UserEntity User { get; set; } = null!;
//    }
//}
