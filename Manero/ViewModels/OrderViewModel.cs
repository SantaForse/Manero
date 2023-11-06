namespace Manero.ViewModels
{
    public class OrderViewModel
    {
        public int? OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? OrderTotal { get; set; }
        


        // placeholders        
        public string? OrderStatus { get; set; }
        public string? OrderItem { get; set; }
        public int? OrderItemQuantity { get; set; }
        public decimal? OrderItemPrice  { get; set; }
    }
}
