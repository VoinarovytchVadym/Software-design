using System.Text.RegularExpressions;

namespace Proxy;

public class SmartTextReaderLocker(string regex) : ISmartTextReader
{
    private readonly SmartTextChecker _checker = new();
    private readonly Regex _regex = new(regex);

    public char[][] ReadText(string path)
    {
        if (_regex.IsMatch(path))
        {
            Console.WriteLine("Access denied!");
            return null;
        }
        else
        {
            return _checker.ReadText(path);
        }
    }
}