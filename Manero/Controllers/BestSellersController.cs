using Manero.Models.Entities;
using Manero.Services;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class BestSellersController : Controller
    {
        
		private readonly ProductsService productsService;

        public BestSellersController(ProductsService productsService)
        {
            this.productsService = productsService;
        }




        //Views
        public IActionResult Index()
        {
            IEnumerable<ProductEntity> siteProducts = productsService.GetProducts();
            return View(siteProducts);
        }


        public IActionResult ProductFilter()
        {
            return View();
        }
    }
}
