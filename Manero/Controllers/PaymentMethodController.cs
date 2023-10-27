using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class PaymentMethodController : Controller
    {
        public IActionResult PaymentMethodIndex()
        {
            return View();
        }

        public IActionResult PaymentMethodAdd()
        {
            return View();
        }
    }
}
