namespace Manero.Models.Entities
{
    public class SizeEntity
    {
        public int Id { get; set; }
        public string SizeName { get; set; } = null!;

        public ICollection<ProductSizeEntity> ProductSizes { get; set; } = new List<ProductSizeEntity>();
    }
}
