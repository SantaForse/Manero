using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers;

public class ProductsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Product()
    {

        //Will load up product via Id then create a product details page for it... 
        return View();
    }

}
