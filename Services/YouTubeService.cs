using System.ServiceModel.Syndication;
using System.Xml;

public class YouTubeService
{
    private const string YouTubeUrl = "https://www.youtube.com/feeds/videos.xml?channel_id=UCIPMDupgTRsJY5sxcdBEtCg";
    public IEnumerable<YouTubeVideo> GetFeed()
    {
        using var reader = XmlReader.Create(YouTubeUrl);
        var feed = SyndicationFeed.Load(reader);

        var youTubeVideos = feed.Items.Take(3).Select(item => new YouTubeVideo
        {
            Title = item.Title.Text,
            Link = item.Links.FirstOrDefault()?.Uri.ToString(),
            ThumbnailUrl = $"https://img.youtube.com/vi/{item.Id.Split(":").Last()}/mqdefault.jpg",
            PublishDate = item.PublishDate
        });

        return youTubeVideos;
    }
}

public class YouTubeVideo
{
    public string? Title { get; set; }
    public string? Link { get; set; }
    public string? ThumbnailUrl { get; set; }
    public DateTimeOffset PublishDate { get; set; }
}




