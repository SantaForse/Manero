using System.ComponentModel.DataAnnotations;

namespace Manero.ViewModels
{
    public class UserProfileViewModel
    {
        public string? FirstName { get; set; } = null!;
        public string? LastName { get; set; } = null!;
        public string? Email { get; set; } = null;
        public string? Phone { get; set; }
        public string? Location { get; set; }
        public string? ImageUrl { get; set; } = null;



        [Display(Name = "Product Image")]
        [DataType(DataType.Upload)]
        public IFormFile? Image { get; set; }


        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Title")]
        public string? AddressCategory { get; set; }

        [Required(ErrorMessage = "Street name is required")]
        [Display(Name = "Street name")]
        public string? StreetName { get; set; }

        [Required(ErrorMessage = "Street number is required")]
        [Display(Name = "Street number")]
        public string? StreetNumber { get; set; }


        [Required(ErrorMessage = "City is required")]
        [Display(Name = "City")]
        public string? City { get; set; }

    }
}
