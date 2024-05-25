namespace Decorator.Inventories;

public abstract class Inventory()
{
    public virtual string Equip(string text)
    {
        return " Equipped";
    }
}