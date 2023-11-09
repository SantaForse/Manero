using Manero.Models;

namespace Manero.ViewModels;

public class CardGridViewModel
{
    public string Title { get; set; } = null!;

    public string ButtonText { get; set; } = null!;

    public string ButtonLink { get; set; } = null!;
    
    public int CardNr { get; set; }

}
