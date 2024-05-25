namespace Lab_4;

public class ThirdHandler : BaseHandler
{
    public override void Handle()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Пристрій підключено але всеодно не працює: ");
        Console.ForegroundColor = ConsoleColor.White;
        switch(Console.ReadLine())
        {
            case "1":
                Console.WriteLine("\nПеревірте чи ви не сплутали порти підключення.");
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