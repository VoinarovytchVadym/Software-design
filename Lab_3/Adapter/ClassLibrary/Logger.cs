namespace Adapter.ClassLibrary;

public class Logger
{
    public void Log(string output)
    {
        StylizedOutput(output, ConsoleColor.Green);
    }

    public void Error(string output)
    {
        StylizedOutput(output, ConsoleColor.Red);
    }

    public void Warning(string output)
    {
        StylizedOutput(output, ConsoleColor.DarkYellow);
    }

    private void StylizedOutput(string output, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(output);
        Console.ResetColor();
    }
}