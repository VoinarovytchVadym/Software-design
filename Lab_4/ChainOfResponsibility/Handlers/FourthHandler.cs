namespace Lab_4;

public class FourthHandler : BaseHandler
{
    public override void Handle()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Пристрій підключено коректно та налаштований правильно, але проблема не зникла: ");
        Console.ForegroundColor = ConsoleColor.White;
        switch(Console.ReadLine())
        {
            case "1":
                Console.WriteLine("\nПеревірте пристрій виводу на іншому пристої, та зверністься до сервісу якщо воно всеодно не працює.");
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