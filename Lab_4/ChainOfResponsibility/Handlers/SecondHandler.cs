namespace Lab_4;

public class SecondHandler : BaseHandler
{
    public override void Handle()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Звук працює але не стабільно: ");
        Console.ForegroundColor = ConsoleColor.White;
        switch(Console.ReadLine())
        {
            case "1":
                Console.WriteLine("\nПеревірте підключення пристрою виводу.");
                Console.WriteLine("Проблема зникла?");
                
                if (Input() == "1")
                    Environment.Exit(0);
                else  base.HandleNext();
                break;
            case "0":
                base.HandleNext();
                break;
        }
    }
}