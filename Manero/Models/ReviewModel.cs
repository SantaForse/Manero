using Manero.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Manero.Models;

public class ReviewModel
    {
    public int Id { get; set; }
    public int Rating { get; set; }
    public string CommentText { get; set; } = null!;
    public DateTime ReviewDate { get; set; }
}

