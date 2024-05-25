namespace Lab_2.task_4;

public class Virus(string name, int weight, int age, string type, List<Virus> children)
    : ICloneable
{
    private string Name { get; set; } = name;
    private int Weight { get; set; } = weight;
    private int Age { get; set; } = age;
    private string Type { get; set; } = type;
    public List<Virus> Children { get; private set; } = children;


    public override string ToString()
    {
        string childrenInfo = Children.Count > 0 ? "\n{"+$"{string.Join("", Children)}"+"}\n" : "";
        return $"Name: {Name}, Weight: {Weight}, Age: {Age}, Type: {Type}, Children(of-{Name}):{childrenInfo}   ";
    }

    public object Clone()
    {
        var virus = (Virus) this.MemberwiseClone();
        virus.Children = new List<Virus>();

        foreach (var child in Children)
        {
            virus.Children.Add((Virus)child.Clone());
        }
        return virus;
    }
}