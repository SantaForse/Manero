using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class OrderHistoryController : Controller
    {
        public IActionResult OrderHistoryIndex()
        {
            return View();
        }
    }
}
