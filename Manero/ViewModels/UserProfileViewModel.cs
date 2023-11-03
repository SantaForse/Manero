using System.ComponentModel.DataAnnotations;

namespace Manero.ViewModels
{
    public class UserProfileViewModel
    {
        public string? FirstName { get; set; } = null!;
        public string? LastName { get; set; } = null!;
        public string? Email { get; set; } = null;
        public string? ImageUrl { get; set; } = null;



        [Display(Name = "Product Image")]
        [DataType(DataType.Upload)]
        public IFormFile? Image { get; set; }




        public string? AddressCategory { get; set; }
        public string? StreetNumber { get; set; }
        public string? StreetName { get; set; }
        public string? City { get; set; }

    }
}
