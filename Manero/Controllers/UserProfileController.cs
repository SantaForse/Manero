using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class UserProfileController : Controller
    {

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
