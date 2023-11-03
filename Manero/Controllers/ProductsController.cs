using Manero.Models;
using Manero.Services;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers;

public class ProductsController : Controller
{
    //Injection of services
    private readonly ProductService productService;

    public ProductsController(ProductService productService)
    {
        this.productService = productService;
    }


    public IActionResult Index()
    {
        //Populates the view with a list of all products
        List<ProductEntity> products = productService.GetAllProducts();

        return View(products);
    }


    //Routes to the specifik Products page
    [Route("Products/{productName}")]
    public IActionResult Product(string productName)
    {
        //Populates the view with a single product, by name
        ProductEntity product = productService.GetProductByName(productName);

        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }

}
