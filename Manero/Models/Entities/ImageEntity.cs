namespace Manero.Models.Entities
{
    public class ImageEntity
    {
        public int Id { get; set; }
        public string ImageName { get; set; } = null!;
        public string ImageURL{ get; set; } = null!;

        public ICollection<ProductImageEntity> ProductImages { get; set; } = new List<ProductImageEntity>();
    }
}
