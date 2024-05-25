namespace LightWeight;

abstract class Program
{
    static void Main()
    {

        string path = @"D:\\Навчання\\Software-design\\Lab_3\\LightWeight\\text.txt";
        string text = ToHTML.GetTextFromFile(path);
        Console.WriteLine(text);
        try
        {
            var HTML_book = ToHTML.WithoutLightWeight(text);
            Console.WriteLine(HTML_book.OuterHTML);
            long memoryUsage = MemoryCalculator.CalculateMemoryUsage(HTML_book);
            Console.WriteLine($"Memory Usage: {memoryUsage} ");


            var HTML_book2 = ToHTML.ConvertToHTML(text);
            memoryUsage = MemoryCalculator.CalculateMemoryUsage(HTML_book2);
            Console.WriteLine($"Memory Usage after: {memoryUsage} ");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
 



}