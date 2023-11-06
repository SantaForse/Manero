using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Entities
{
    [PrimaryKey(nameof(ProductId), nameof(ColorId))]
    public class ProductColorEntity
    {
        public int ProductId { get; set; }
        public int ColorId { get; set; }


        public ProductEntity Product { get; set; } = null!;
        public ColorEntity Color { get; set; } = null!;
    }
}
