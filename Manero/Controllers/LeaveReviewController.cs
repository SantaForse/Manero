
using Manero.Models.Entities;
using Manero.Services;
using Manero.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Manero.Controllers
{
    public class LeaveReviewController : Controller
    {
        private readonly ProductsService productsService;
        private readonly ReviewService reviewService;

        public LeaveReviewController(ProductsService productsService, ReviewService reviewService)
        {
            this.productsService = productsService;
            this.reviewService = reviewService;
        }

        public IActionResult Index()
        {
           

            int productId = 0;
            if (!Request.Query.ContainsKey("ProductId"))
            {
                return NotFound();
            }
            productId = int.Parse(Request.Query.First(x => x.Key == "ProductId").Value.ToString());

            ReviewEntry model = new ReviewEntry()
            {
                ProductId = productId
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AddComment(ReviewEntry viewModel)
        {
            if (ModelState.IsValid)
            {
                var newComment = new ReviewEntity
                {
                    Rating = viewModel.Rating,
                    CommentText = viewModel.CommentText,
                    ReviewDate = DateTime.Now
                };

                var product = productsService.GetProductById(viewModel.ProductId);
                //var product = productsService.GetProductByName(viewModel.ProductName);

                if (product != null)
                {
                    
                    reviewService.AddReview(newComment, product.Id);

                    //return LocalRedirect($"/Products/Reviews?productName={product.ProductName}"); 
                    return LocalRedirect($"/home");
                }
                else
                {
                   
                    ModelState.AddModelError("ProductName", "Product not found");
                }
            }

            return View("Index", viewModel);
        }
    }
}


























































