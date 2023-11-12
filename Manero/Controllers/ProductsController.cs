using Manero.Models.Entities;
using Manero.Services;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers;

public class ProductsController : Controller
{
    //Injection of services
    private readonly ProductsService productsService;

    public ProductsController(ProductsService productsService)
    {
        this.productsService = productsService;
    }

    //Views
    public IActionResult Index()
    {
        return View();
    }


    //Routes to the specifik Products page
    [Route("Products/{productName}")]
    public IActionResult Product(string productName)
    {
        //Populates the view with a single product, by name
        ProductEntity product = productsService.GetProductByName(productName);

        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }

    [Route("Products/Reviews")]
    public IActionResult Reviews()
    {
        //Should populate all reviews ofc...
        return View();
    }

}
