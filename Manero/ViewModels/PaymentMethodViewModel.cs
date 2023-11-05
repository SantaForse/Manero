using System.ComponentModel.DataAnnotations;

namespace Manero.ViewModels
{
    public class PaymentMethodViewModel
    {
        public bool PaymentMethodCard { get; set; }
        public string CardType { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string CardExpirationDate { get; set; }


        public bool PaymentMethodApplePay { get; set; }
        public bool PaymentMethodPayPal { get; set; }
        public bool PaymentMethodPayoneer { get; set; }
    }
}
