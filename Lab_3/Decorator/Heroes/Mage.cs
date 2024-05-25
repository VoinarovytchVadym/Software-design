using Decorator.Inventories;

namespace Decorator.Heroes;

public class Mage(string name, Inventory inventory) : IHero
{
    public string Name { get; set; } = name;
    public Inventory Inventory { get; set; } = inventory;
}