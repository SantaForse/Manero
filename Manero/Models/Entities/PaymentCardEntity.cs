namespace Manero.Models.Entities
{
    public class PaymentCardEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string CardNumber { get; set; } = null!;

        public int ExpireDate { get; set; }
        public int CVVCode { get; set; }
    }
}
