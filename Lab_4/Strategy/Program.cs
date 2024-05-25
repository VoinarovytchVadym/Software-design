using Strategy.Strategies;

namespace Strategy;

abstract class Program
{
    static void Main(string[] args)
    {
        IStrategy loadingStrategy = new NetworkStrategy();
        var image = new Image(loadingStrategy, "https://cdn-prod.medicalnewstoday.com/content/images/articles/322/322868/golden-retriever-puppy.jpg",
            []);
        loadingStrategy = new FileStrategy();
        var image2 = new Image(loadingStrategy, @"D:\Навчання\Software-design\Lab_4\Strategy\golden-retriever-puppy.jpg",
            []);

        image.DisplayImage();
        Console.WriteLine($"{image.OuterHTML}");
        
        
        Console.WriteLine("");
        
        image2.DisplayImage();
        Console.WriteLine($"{image2.OuterHTML}");

    }
}