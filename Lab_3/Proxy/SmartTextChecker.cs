namespace Proxy;

public class SmartTextChecker : ISmartTextReader
{
    private readonly SmartTextReader _reader = new();

    public char[][] ReadText(string path)
    {
        Console.WriteLine("Opening file: " + path);
        char[][] result = _reader.ReadText(path);
        {
            Console.WriteLine("successfully!");
            Console.WriteLine("Lines count: " + result.Length);
            int chars = 0;
            foreach (var line in result)
            {
                chars += line.Length;
            }
            Console.WriteLine("Characters count: " + chars);
        }
        Console.WriteLine("Closing file: " + path);
        return result;
    }
}