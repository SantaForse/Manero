using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class UserProfileController : Controller
    {

        public IActionResult UserProfileIndex()
        {
            return View();
        }

        public IActionResult UserProfileEdit()
        {
            return View();
        }





        public IActionResult UserAddressIndex()
        {
            return View();
        }
        public IActionResult UserAddressAdd()
        {
            return View();
        }





        public IActionResult UserPromoCodesIndex()
        {
            return View();
        }
    }
}
