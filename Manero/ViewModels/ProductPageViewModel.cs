
using Manero.Models.Entities;
using System.Collections.Generic;

namespace Manero.ViewModels
{
    public class ProductPageViewModel
    {
        public ProductEntity Product { get; set; } = null!;
        public List<ReviewEntity> Reviews { get; set; } = null!;
        public int Rating { get; set; }
        public decimal Price { get; set; }
        public string ProductName { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
