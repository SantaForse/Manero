using Manero.Models;
using Manero.Services;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers;

public class WishListController : Controller
{
    //Services
    private readonly ProductService productService;

    public WishListController(ProductService productService)
    {
        this.productService = productService;
    }



    //Views
    public IActionResult Index()
    {
        //Should populate view with only liked products
        List<ProductEntity> siteProducts = productService.GetAllProducts();
        return View(siteProducts);
    }
}
