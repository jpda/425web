using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _425ShowWebsite.Pages;

public class IndexModel : PageModel
{
    private YouTubeService? _youTubeService;
    private readonly ILogger<IndexModel> _logger;

    public List<YouTubeVideo>? YouTubeVideos { get; set; }
    public bool IsProd{ get; set; }

    public IndexModel(ILogger<IndexModel> logger, YouTubeService? youTubeService)
    {
        _logger = logger;
        _youTubeService = youTubeService;
    }

    public void OnGet()
    {
        YouTubeVideos = _youTubeService?.GetFeed()?.ToList();
    }
}
