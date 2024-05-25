
namespace Proxy;

abstract class Program
{
    static void Main()
    {
    
        string file1 = "file1.txt";
        string file2 = "file2.txt";
        
        File.WriteAllText(file1, "Some\nText!");
        File.WriteAllText(file2, "Some\nOther\nText!");

        ISmartTextReader reader1 = new SmartTextChecker();
        ISmartTextReader reader2 = new SmartTextReaderLocker("file1.*");
        
        char[][] result1 = reader1.ReadText(file1);

        Console.WriteLine();

        char[][] result3 = reader1.ReadText(file2);
        
        Console.WriteLine();

        char[][] result2 = reader2.ReadText(file1);
        
        Console.WriteLine();
        
        char[][] result4 = reader2.ReadText(file2);


        File.Delete(file1);
        File.Delete(file2);
    }
}