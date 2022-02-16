using System.Text.Json;
public class TwitterSpaceService
{
    private const string TwitterSpaceUrl = "";
    private HttpClient? _httpClient;

    public TwitterSpaceService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<IEnumerable<TwitterSpace>> GetData()
    {
        var twitterSpaces = await _httpClient.GetFromJsonAsync<List<TwitterSpace>>(TwitterSpaceUrl);
        return twitterSpaces;
    }
}
public class Link
{
    public string? LinkText { get; set; }
    public string? LinkUrl { get; set; }
}

public class TwitterSpace
{
    public string? Topic { get; set; }
    public DateTime? RecordingDate { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string? Link { get; set; }
    public string? Summary { get; set; }
    public List<Link>? Links { get; set; }
}