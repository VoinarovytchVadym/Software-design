using Adapter.ClassLibrary;

namespace Adapter;

public abstract class Program
{
    private const string Path = "text.txt";

    private static void Main()
    {
        var logger = new Logger();
        logger.Log("Console Log");
        logger.Error("Console Error");
        logger.Warning("Console Warning");

        var writer = new FileWriter(Path);
        writer.Clear();
        writer.WriteLine($"File Log");
        writer.Write($"File Warning");
        Console.WriteLine(File.ReadAllText(Path));

        var fileLoggerAdapter = new FileLoggerAdapter(Path);
        fileLoggerAdapter.Log("Log");
        fileLoggerAdapter.Error("Error");
        fileLoggerAdapter.Warning("Warning");
    }
}