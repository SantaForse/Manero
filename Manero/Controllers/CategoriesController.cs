using Manero.Models;
using Manero.Models.Entities;
using Manero.Services;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers;

public class CategoriesController : Controller
{

    //Injections
    private readonly ProductsService productsService;

    public CategoriesController(ProductsService productsService)
    {
        this.productsService = productsService;
    }




    //Views
    public IActionResult Index()
    {
        return View();
    }

    //Routes to the specifik category page
    [Route("Category/{productCategory}")]
    public IActionResult Category()
    {

        //Alternativt bör denna ladda upp alla producter från categories istället 
        IEnumerable<String> categories = productsService.GetAllUniqueCategories();

        if (categories == null)
        {
            return NotFound();
        }

        return View(categories);
    }


}
