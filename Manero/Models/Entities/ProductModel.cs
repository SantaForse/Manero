namespace Manero.Models.Entities
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = null!;
        public string? Description { get; set; }
        public double? Rating { get; set; }
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }

       
    }
}
