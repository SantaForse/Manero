namespace Manero.Models.Entities
{
    public class ColorEntity
    {
        public int Id { get; set; }
        public string ColorName { get; set; } = null!;

        public ICollection<ProductColorEntity> ProductColors { get; set; } = new HashSet<ProductColorEntity>();
    }
}
