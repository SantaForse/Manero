using manero.Models;
using Manero.Controllers;
using Manero.Models;
using Manero.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace manero.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		//Will be replaced later!
        List<ProductEntity> siteProducts = new List<ProductEntity>()
        {

		// Static products, should Get from db
            new ProductEntity { Id = 1, ProductName = "Knitted summer top", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 31 , ProductRating = 4, ProductTag = "new"},
            new ProductEntity { Id = 2, ProductName = "Nice summer top", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 29 , ProductRating = 2, ProductTag = "top"},
            new ProductEntity { Id = 3, ProductName = "New summer top", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 35 , ProductRating = 5, ProductTag = "sale"},
            new ProductEntity { Id = 4, ProductName = "Old fashioned top", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 12 , ProductRating = 3, ProductTag = ""},

            new ProductEntity { Id = 5, ProductName = "Knitted summer top", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 31 , ProductRating = 4, ProductTag = "new"},
            new ProductEntity { Id = 6, ProductName = "Nice summer top", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 29 , ProductRating = 2, ProductTag = "top"},
            new ProductEntity { Id = 7, ProductName = "New summer top", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 35 , ProductRating = 5, ProductTag = "sale"},
            new ProductEntity { Id = 8, ProductName = "Old fashioned top", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 12 , ProductRating = 3, ProductTag = ""},

            new ProductEntity { Id = 9, ProductName = "Knitted summer top", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 31 , ProductRating = 4, ProductTag = "new"},
            new ProductEntity { Id = 10, ProductName = "Nice summer top", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 29 , ProductRating = 2, ProductTag = "top"},
            new ProductEntity { Id = 11, ProductName = "New summer top", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 35 , ProductRating = 5, ProductTag = "sale"},
            new ProductEntity { Id = 12, ProductName = "Old fashioned top", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 12 , ProductRating = 3, ProductTag = ""}

        };

        
        public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

        public IActionResult Index()
        {
            return View(siteProducts);
        }

        public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}

}