using Manero.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Manero.ViewModels
{
    public class PaymentCardAddViewModel
    {
        public string? UserId { get; set; }


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
        public int CardCVV { get; set; }




        public static implicit operator PaymentCardEntity(PaymentCardAddViewModel model)
        {
            var paymentCardEntity = new PaymentCardEntity
            {
                Name = model.CardHolderName,
                CardNumber = model.CardNumber,
                ExpireDate = model.CardExpirationDate,
                CVVCode = model.CardCVV
            };
            return paymentCardEntity;
        }
    }
}
