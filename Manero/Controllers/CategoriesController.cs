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
    public IActionResult Category(string productCategory)
    {
        
        //This one gets one category from db and then creates that view 
        CategoryEntity category = productsService.GetCategory(productCategory);

        if (category == null)
        {
            return NotFound();
        }

        return View(category);
    }


}
