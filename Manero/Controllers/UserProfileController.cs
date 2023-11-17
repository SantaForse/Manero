using Manero.Services;
using Manero.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class UserProfileController : Controller
    {
        //christian 14/11
        private readonly UserService _userService;
        public UserProfileController(UserService userService)
        {
            _userService = userService;
        }


        
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult UserAddress()
        {
            return View();
        }        
        


        public IActionResult UserAddressAdd()
        {
            return View();
        }



        public IActionResult UserOrderHistory()
        {
            return View();
        }



        public IActionResult UserPaymentMethods()
        {
            return View();
        }


        public IActionResult UserPaymentMethodAdd()
        {
            return View();
        }


        [HttpPost] //christian 14/11
        public async Task<IActionResult> UserPaymentMethodAddPost(PaymentCardAddViewModel model, string userId)
        {
            await _userService.AddNewPaymentCard(model, userId);

            return RedirectToAction("UserPaymentMethods", "UserProfile");
        }





        public IActionResult UserProfileEdit()
        {
            return View();
        }



        public IActionResult UserPromoCodes()
        {
            return View();
        }
    }
}
