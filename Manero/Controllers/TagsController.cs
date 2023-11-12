using Manero.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Manero.Controllers;

public class TagsController : Controller
{
    //Service
    private readonly TagsService tagsService;

    public TagsController(TagsService tagsService)
    {
        this.tagsService = tagsService;
    }


    //Views
    [Route("Tag/{tagName}")]
    public IActionResult TagsPage(string tagName)
    {
        var model = tagsService.GetTag(tagName);

        if (model == null)
        {
            return NotFound();
        }

        return View("TagsPage", model);
    }




}
