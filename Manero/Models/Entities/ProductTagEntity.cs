using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Entities
{
    [PrimaryKey(nameof(ProductId), nameof(TagId))]
    public class ProductTagEntity
    {
        public int ProductId { get; set; }
        public int TagId { get; set; }

        public  ICollection<ProductTagEntity> ProductTags { get; set; } = null!;
    }
}
