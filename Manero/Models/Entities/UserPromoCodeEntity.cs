using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Entities
{
    [PrimaryKey(nameof(UserId), nameof(PromoCodeId))]
    public class UserPromoCodeEntity
    {
        public string UserId { get; set; }
        public int PromoCodeId { get; set; }

        public PromoCodeEntity PromoCode { get; set; } = null!;
    }
}
