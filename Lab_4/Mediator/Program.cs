using Agent;

public abstract class Program
{
    static void Main(string[] args)
    {
        var runway1 = new Runway();
        var runway2 = new Runway();
        
        var commandCentre = new CommandCenter(new[] { runway1, runway2 });

        var aircraft1 = new Aircraft("A1");
        var aircraft2 = new Aircraft("A2");
        var aircraft3 = new Aircraft("A3");

        Console.ForegroundColor = ConsoleColor.Blue;
        
        commandCentre.RequestLanding(aircraft1);
        Console.WriteLine();

        commandCentre.RequestLanding(aircraft2);
        Console.WriteLine();

        commandCentre.RequestLanding(aircraft3);
        Console.WriteLine();

        commandCentre.RequestTakeOff(aircraft1);
        Console.WriteLine();
        
        commandCentre.RequestLanding(aircraft3);
        Console.WriteLine();
        
    }
}