using Manero.Models;
using Manero.Models.Entities;
using Manero.Services;
using Manero.ViewModels;
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


    public IActionResult Index2()
    {
        return View();

    }

    [HttpPost]
    public IActionResult Index2(SearchViewModel searchViewModel)
    {
        var products = productsService.SearchProductsByString(searchViewModel.SearchWord);

        if (products == null)
        {
            return View("Error");
        }
        return RedirectToRoute(Index3(products));

    }

    public IActionResult Index3(IEnumerable<Models.Entities.ProductEntity> products)
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
