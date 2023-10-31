using Manero.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CheckoutViewModel viewModel)
        {
            //return order sucessful view if sucessful, otherwise return order failed view.
            return RedirectToAction("OrderFailed");
        }

        public IActionResult OrderFailed()
        {
            return View();
        }

        public IActionResult OrderSuccessful()
        {
            return View();
        }
    }
}
