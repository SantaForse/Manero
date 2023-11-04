using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class BestSellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }





        public IActionResult ProductFilter()
        {
            return View();
        }
    }
}
