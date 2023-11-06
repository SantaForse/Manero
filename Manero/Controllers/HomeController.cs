using manero.Models;
using Manero.Controllers;
using Manero.Models;
using Manero.Services;
using Manero.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace manero.Controllers
{
	public class HomeController : Controller
	{
		//Services
		private readonly ILogger<HomeController> _logger;

		private readonly ProductService productService;

        public HomeController(ILogger<HomeController> logger, ProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }


		//Views
        public IActionResult Index()
        {
            //Populates the view with a list of all products
            List<ProductEntity> siteProducts = productService.GetAllProducts();
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