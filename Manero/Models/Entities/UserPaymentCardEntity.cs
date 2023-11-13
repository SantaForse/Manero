using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Entities
{
    [PrimaryKey("UserId", "PaymentCardId")]
    public class UserPaymentCardEntity
    {
        public string UserId { get; set; } = null!;
        public int PaymentCardId { get; set; }
        public PaymentCardEntity PaymentCard { get; set; } = null!;



    }
}
