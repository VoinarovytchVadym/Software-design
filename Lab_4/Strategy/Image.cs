using Composer.Nodes;
using Strategy.Strategies;

namespace Strategy;

public class Image(IStrategy loadingStrategy, string src, List<string> cssClasses, string displayType = "inline")
    : LightElementNode("img", displayType, "selfClosing", cssClasses, [])
{
    public override string OuterHTML
    {
        get
        {
            string cssClassStr = string.Join(" ", Classes);
            string attributes = $"class=\"{cssClassStr}\" src=\"{src}\"";

            if (ClosingType == "selfClosing")
                return $"<{TagName} {attributes}/>";
            else
                return $"<{TagName} {attributes}></{TagName}>";
        }
    }
    public void DisplayImage()
    {
        byte[] imageData = loadingStrategy.Load(src);
        Console.WriteLine($"Displaying image from {src}");
    }
}