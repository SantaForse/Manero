namespace Manero.ViewModels;

public class NavbarViewModel
{

    //Decides to show either Burger or Arrow
    public bool Burger { get; set; } = true;

    //Decides over whether to show the cart button or not
    public bool ShoppingCart { get; set; } = true;

    //Decides over the information in the middle
    public string MiddleData { get; set; } = null!;

}
