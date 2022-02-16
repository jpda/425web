using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _425ShowWebsite.Pages;

public class SpacesModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly TwitterSpaceService _twitterSpaceService;

    public IEnumerable<TwitterSpace> TwitterSpaces { get; set; }

    public SpacesModel(ILogger<IndexModel> logger, TwitterSpaceService twitterSpaceService)
    {
        _logger = logger;
        _twitterSpaceService = twitterSpaceService;
    }

    public async Task OnGet()
    {
        TwitterSpaces = await _twitterSpaceService.GetData();
    }
}