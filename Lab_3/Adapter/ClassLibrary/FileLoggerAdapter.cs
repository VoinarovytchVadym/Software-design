namespace Adapter.ClassLibrary;

public class FileLoggerAdapter(string filePath) : FileWriter(filePath)
{
    public void Log(string message)
    {
        StylizedOutput("File logger " + message, ConsoleColor.Green);
    }

    public void Error(string message)
    {
        StylizedOutput("File logger " + message, ConsoleColor.Red);
    }

    public void Warning(string message)
    {
        StylizedOutput("File logger " + message, ConsoleColor.DarkYellow);
    }

    private void StylizedOutput(string output, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(output);
        Console.ResetColor();
    }
}