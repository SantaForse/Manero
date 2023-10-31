using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            //if there is products in cart return index view otherwise return CartEmpty.cshtml view
            return View();
        }

    }
}
