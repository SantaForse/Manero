using Manero.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Manero.Models;

public class CommentModel
    {
     public int Id { get; set; }

    [Required]
    public string CommentText { get; set; } = null!;
}

