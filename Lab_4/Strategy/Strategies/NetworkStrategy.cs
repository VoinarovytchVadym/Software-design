using System.Net;

namespace Strategy.Strategies;

public class NetworkStrategy : IStrategy
{
    [Obsolete("Obsolete")]
    public byte[] Load(string href)
    {
        using var webClient = new WebClient();
        return webClient.DownloadData(href);
    }
}