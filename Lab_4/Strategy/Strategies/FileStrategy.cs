namespace Strategy.Strategies;

public class FileStrategy : IStrategy
{
    public byte[] Load(string href)
    {
        return File.ReadAllBytes(href);
    }
}