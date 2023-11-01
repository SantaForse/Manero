using System.ComponentModel.DataAnnotations;

namespace Manero.ViewModels
{
    public class TrackViewModel
    {
        [Required]
        [Display(Name = "ORDER NUMBER")]
        public string OrderNumber { get; set; }
    }
}
