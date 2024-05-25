using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Lab_4;

public class FirstHandler : BaseHandler
{
    
    public override void Handle()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Програма діагностики проблем зі звуком.");
        Console.WriteLine("Введіть '1' якщо твердження є вірним, інакше виберіть '0'.");
        Console.WriteLine("Не чути звуку: ");
        Console.ForegroundColor = ConsoleColor.White;
        
        switch(Input())
        {
            case "1":
                Console.WriteLine("\nПеревірте пристрій виводу звуку.");
                Console.WriteLine("\nПроблема зникла?");
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