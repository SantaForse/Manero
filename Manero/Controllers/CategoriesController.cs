using Manero.Models;
using Manero.Services;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers;

public class CategoriesController : Controller
{

    //Injections
    private readonly ProductService productService;

    public CategoriesController(ProductService productService)
    {
        this.productService = productService;
    }


    //Views
    public IActionResult Index()
    {
        return View();
    }

    //Routes to the specifik category page
    [Route("Category/{productCategory}")]
    public IActionResult Category(string productCategory)
    {
        List<ProductEntity> productsInCategory = productService.GetProductsByCategory(productCategory);

        if (productsInCategory.Count == 0)
        {
            return NotFound();
        }

        return View(productsInCategory);
    }


}
