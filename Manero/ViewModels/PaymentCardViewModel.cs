using Manero.Models.Entities;

namespace Manero.ViewModels
{
    public class PaymentCardViewModel
    {
        public string Name { get; set; } = null!;
        public string CardNumber { get; set; } = null!;

        public string ExpireDate { get; set; }
        public int CVVCode { get; set; }

    }
}
