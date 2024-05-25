using Decorator.Inventories;

namespace Decorator.Heroes;

public interface IHero
{
    public string Name { get; set; }
    public Inventory Inventory { get; set; }
}