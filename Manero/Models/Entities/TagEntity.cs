namespace Manero.Models.Entities
{
    public class TagEntity
    {
        public int Id{ get; set; }
        public string TagName { get; set; } = null!;

        public ICollection<ProductTagEntity> ProductTags { get; set; } = new List<ProductTagEntity>();
    }
}
