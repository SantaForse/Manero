using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Manero.Areas.Identity.Pages.Account
{
    public class PhoneVerifyModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public PhoneVerifyModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            [Required(ErrorMessage = "Please select a country prefix.")]
            public string CountryPrefix { get; set; }

            [Required(ErrorMessage = "Please enter a valid phone number.")]
            [Phone(ErrorMessage = "The phone number entered is not valid.")]
            public string Phonenumber { get; set; }
        }

        [TempData]
        public string SmsSentMessage { get; set; }

        public IActionResult OnGet()
        {
            Input = new InputModel{};
            SmsSentMessage = null;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var TotalPhoneNumber = Input.CountryPrefix + Input.Phonenumber;
                SmsSentMessage = $"We have sent you an SMS with a code to number {TotalPhoneNumber}";
            }

            return Page();
        }
    }
}
