using System.Text;

namespace Lab_4;

public class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        
        var first = new FirstHandler();
        var second = new SecondHandler();
        var third = new ThirdHandler();
        var fourth = new FourthHandler();

        first.SetNextHandler(second);
        second.SetNextHandler(third);
        third.SetNextHandler(fourth);
        fourth.SetNextHandler(first);
        first.Handle();
    }
}