using System.ComponentModel.DataAnnotations;

namespace Manero.ViewModels
{
    public class PaymentCardAddViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "NAME")]
        public string? CardHolderName { get; set; }


        [Required(ErrorMessage = "Card number is required")]
        [Display(Name = "CARD NUMBER")]
        public string? CardNumber { get; set; }


        [Required(ErrorMessage = "Expiration date is required")]
        [Display(Name = "MM / YY")]
        public string? CardExpirationDate { get; set; }


        [Required(ErrorMessage = "CVV is required")]
        [Display(Name = "CVV")]
        public string? CardCVV { get; set; }
    }
}
