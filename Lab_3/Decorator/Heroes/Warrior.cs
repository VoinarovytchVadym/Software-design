using Decorator.Inventories;

namespace Decorator.Heroes;

public class Warrior(string name, Inventory inventory) : IHero
{
    public string Name { get; set; } = name;
    public Inventory Inventory { get; set; } = inventory;
}