using Manero.Models;
using Manero.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class LeaveReviewController : Controller
    {
        private List<ReviewModel> comments = new List<ReviewModel>();

        public IActionResult Index()
        {
            var viewModel = new ReviewViewModel
            {
                Comments = comments
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddComment(ReviewViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var newComment = new ReviewModel
                {
                    Rating = viewModel.Rating,
                    CommentText = viewModel.NewCommentText,
                    ReviewDate = DateTime.Now
                };
                comments.Add(newComment);
            }

            return RedirectToAction("Index");
        }
    }
}