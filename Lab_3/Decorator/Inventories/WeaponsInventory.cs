namespace Decorator.Inventories;

public class WeaponsInventory(Inventory inventory = null) : Inventory()
{
    public override string Equip(string text)
    {
        return "Weapon " + text + " Equipped";
    }
}