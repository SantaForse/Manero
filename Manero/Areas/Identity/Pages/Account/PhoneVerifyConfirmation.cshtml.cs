using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Manero.Areas.Identity.Pages.Account
{
    public class PhoneVerifyConfirmationModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public PhoneVerifyConfirmationModel(UserManager<IdentityUser> userManager)
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
            [Required(ErrorMessage = "OTP is required.")]
            [StringLength(5, ErrorMessage = "The OTP must be 5 characters long.")]
            public string OTPCode { get; set; }
        }

        public IActionResult OnGet()
        {
            Input = new InputModel { };
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
               var otpCode = Input.OTPCode;

                ModelState.AddModelError(string.Empty, "Invalid OTP.");
            }

            return Page();
        }

    }
}
