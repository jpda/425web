using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _425ShowWebsite.Pages;

public class SpacesModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;


    public SpacesModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
    }
}