using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Entities
{
    [PrimaryKey(nameof(ProductId), nameof(SizeId))]
    public class ProductSizeEntity
    {
        public int ProductId { get; set; }
        public int SizeId { get; set; }


        public ProductEntity Product { get; set; } = null!;
        public SizeEntity Size { get; set; } = null!;
    }
}
