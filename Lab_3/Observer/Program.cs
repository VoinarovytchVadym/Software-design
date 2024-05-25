
using Composer.Nodes;

namespace Composer;

public abstract class Program
{
    public static void Main()
    {
        var button = new LightElementNode("button", "inline", "closing",
            ["button"],
            [new LightTextNode("Submit")]);

        button.AddEventListener("click", () => Console.WriteLine("Button clicked!"));
        button.AddEventListener("mouseover", () => Console.WriteLine("Mouse is over button!"));
        button.TriggerEvent("click");
        button.TriggerEvent("mouseover");
    }
}
