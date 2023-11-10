namespace Manero.Models.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = null!;
        public string? Description { get; set; }
        public int ? Rating { get; set; }

        
        public int Price { get; set; }

        //I will change it from obligatory, so we can
        //choose if we want sale items /Santa
        public int ? SalePrice { get; set; }
      

        public string ImageUrl { get; set; } = null!;

        public ICollection<ProductCategoryEntity> ProductCategories = new HashSet<ProductCategoryEntity>();
        //public ICollection<ProductColorEntity> ProductColors = new HashSet<ProductColorEntity>();
        //public ICollection<ProductImageEntity> ProductImages = new List<ProductImageEntity>();
        //public ICollection<ProductReviewEntity> ProductReviews = new List<ProductReviewEntity>();
        //public ICollection<ProductSizeEntity> ProductSizes = new List<ProductSizeEntity>();
        //public ICollection<ProductTagEntity> ProductTags = new List<ProductTagEntity>();
    }
}
