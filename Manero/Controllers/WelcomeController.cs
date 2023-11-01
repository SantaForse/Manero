using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

     
        public IActionResult OnboardingFirst()
        {
            return View();
        }

        public IActionResult OnboardingSecond()
        {
            return View();
        }

        public IActionResult OnboardingThird()
        {
            return View();
        }
    }
}
