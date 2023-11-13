using Manero.Models.Entities;
using Manero.Services;
using Manero.ViewModels;
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

        // Get-reviews for the product 
        var reviews = productsService.GetReviews(product.Id).ToList();


        var model = new ProductPageViewModel
        {
            Product = product,
            Reviews = reviews
        };

        return View(model);
    }


    [Route("Products/Reviews")]
    public IActionResult Reviews(string productName)
    {
        var product = productsService.GetProductByName(productName);


        if (product == null)
        {
            return NotFound();
        }


        var reviews = productsService.GetReviews(product.Id).ToList();


        var model = new ProductPageViewModel
        {
            Product = product,
            Reviews = reviews
        };

        return View(model);
    }

}













