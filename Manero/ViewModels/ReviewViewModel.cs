
using Manero.Models;

namespace Manero.ViewModels
{
    public class ReviewViewModel
    {
        public int Rating { get; set; }

        public IEnumerable<ReviewModel>? Comments { get; set; } = null!;
        public string NewCommentText { get; set; } = null!;

    }
}


