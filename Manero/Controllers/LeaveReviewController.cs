using Manero.Models;
using Manero.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class LeaveReviewController : Controller
    {
        private List<CommentModel> comments = new List<CommentModel>();

        public IActionResult Index()
        {
            var viewModel = new CommentViewModel
            {
                Comments = comments
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddComment(CommentViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var newComment = new CommentModel
                {
                    CommentText = viewModel.NewCommentText
                };
                comments.Add(newComment);
            }

            return RedirectToAction("Index");
        }
    }

}