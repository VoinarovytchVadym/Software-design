using Composer;
using Composer.Nodes;

namespace LightWeight;

public class LightElementNode : Composer.Nodes.LightElementNode
{
    private static readonly Dictionary<string, LightElementNode> FlyweightPool = new Dictionary<string, LightElementNode>();

    private LightElementNode(string tagName, string display, string closingType, List<string> classes, List<LightNode> childes)
        :base(tagName,display,closingType,classes,childes)
    {
           
    }

    public static LightElementNode GetElementNode(string tagName, string display, string closingType, List<string> classes, List<LightNode> childes)
    {
        string key = $"{tagName}_{display}_{closingType}_{string.Join(",", classes)}";

        if (!FlyweightPool.TryGetValue(key, out LightElementNode? value))
        {
            value = new LightElementNode(tagName, display, closingType, classes, childes);
            FlyweightPool[key] = value;
        }

        return value;
    }

     
}