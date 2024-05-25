namespace Composer.Nodes;

public class LightElementNode(string tagName, string display, string closingType, List<string> classes, List<LightNode> childes)
    : LightNode
{
    public string TagName { get; } = tagName;
    public string Display { get; } = display;
    public string ClosingType { get; } = closingType;
    public List<string> Classes { get; } = classes;
    public List<LightNode> Childes { get; } = childes;
    private readonly Observer _observer = new Observer();
    public void AddEventListener(string eventType, Action listener)
    {
        _observer.AddEventListener(eventType, listener);
    }
    public void TriggerEvent(string eventType)
    {
        _observer.TriggerEvent(eventType);
    }
    public override string OuterHTML
    {
        get
        {
            string classes = string.Join(" ", Classes);
            string classesString = "";
            if (classes.Length > 0)
            {
                classesString = $" class=\"{classes}\"";
            }
            string child = string.Join("", Childes.ConvertAll(node => node.OuterHTML));

            return ClosingType == "selfClosing" ? $"<{TagName}{classesString}/>" : $"<{TagName}{classesString}>{child}</{TagName}>";
        }
    }

    public override string InnerHTML
    {
        get
        { return string.Join("", Childes.ConvertAll(node => node.OuterHTML)); }
    }
}