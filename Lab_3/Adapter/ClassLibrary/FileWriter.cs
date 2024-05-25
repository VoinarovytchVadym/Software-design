namespace Adapter.ClassLibrary;

public class FileWriter(string filePath)
{
    public void Write(string output)
    {
        using StreamWriter writer = new StreamWriter(filePath, true);
        writer.Write(output);
    }

    public void WriteLine(string output)
    {
        using StreamWriter writer = new StreamWriter(filePath, true);
        writer.WriteLine(output);
    }
    public void Clear()
    {
        File.WriteAllText(filePath, string.Empty);
    }
}