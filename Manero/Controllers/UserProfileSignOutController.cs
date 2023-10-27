using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class UserProfileSignOutController : Controller
    {
        public IActionResult UserProfileSignOutIndex()
        {
            return View();
        }
    }
}
