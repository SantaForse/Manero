using Manero.Models;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers;

public class ProductsController : Controller
{
    //this shouldnt be static...
    List<ProductEntity> products = new List<ProductEntity>()
        {
            new ProductEntity { Id = 1, ProductName = "Knitted summer top", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 31 , ProductRating = 4, ProductTag = "new"},
            new ProductEntity { Id = 2, ProductName = "Nice summer top", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 29 , ProductRating = 2, ProductTag = "top"},
            new ProductEntity { Id = 3, ProductName = "New summer top", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 35 , ProductRating = 5, ProductTag = "sale"},
            new ProductEntity { Id = 4, ProductName = "Old fashioned top", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 12 , ProductRating = 3, ProductTag = ""}

        };

    //this one should be in a service and not in controller
    private ProductEntity GetProductByName(string productName)
    {
            return products.FirstOrDefault(p => p.ProductName == productName)!;
    }



    public IActionResult Index()
    {
        return View(products);
    }

    //Routes to the specifik Products page
    [Route("Products/{productName}")]
    public IActionResult Product(string productName)
    {
        ProductEntity product = GetProductByName(productName);

        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }

    

}
