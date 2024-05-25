namespace Proxy;

public class SmartTextReader : ISmartTextReader
{
    public char[][] ReadText(string path)
    {
        try
        {
            string[] textLines = File.ReadAllLines(path);
            char[][] result = new char[textLines.Length][];
            for (int i = 0; i < textLines.Length; i++)
            {
                result[i] = textLines[i].ToCharArray();
            }
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while reading file: " + ex.Message);
            return null;
        }
    }
}