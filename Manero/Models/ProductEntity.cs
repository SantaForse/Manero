using System.ComponentModel.DataAnnotations;

namespace Manero.Models;

public class ProductEntity
{
    [Key]
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;


    //should have multiple images as well...
    public string? ProductImage { get; set; } 

    public decimal ProductPrice { get; set; }

    public int ProductRating { get; set; }

    public string ProductTag { get; set; } = null!;

    //Borde gå till entity
    public List<string>? Categories { get; set; } 


    //Should probably have tags, and quantity in sizes and colours later
    // and connected to Reviews ofc ^^

}
