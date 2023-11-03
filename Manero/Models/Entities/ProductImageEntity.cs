using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Entities
{
    [PrimaryKey(nameof(ProductId), nameof(ImageId))]
    public class ProductImageEntity
    {
        public int ProductId { get; set; }
        public int ImageId { get; set; }

        public ProductEntity Product { get; set; } = null!;
        public ImageEntity Image { get; set; } = null!;
    }
}
