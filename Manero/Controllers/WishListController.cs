using Manero.Models;
using Manero.Services;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers;

public class WishListController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
}
