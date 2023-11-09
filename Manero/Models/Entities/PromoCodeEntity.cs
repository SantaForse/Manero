namespace Manero.Models.Entities
{
    public class PromoCodeEntity
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; }
        public string? Title { get; set; }
        public int? Discount { get; set; }
        public string? ExpirationDate { get; set; }

        public ICollection<UserPromoCodeEntity> PromoCodes = new HashSet<UserPromoCodeEntity>();
    }
}
