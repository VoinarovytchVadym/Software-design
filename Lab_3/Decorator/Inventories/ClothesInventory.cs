namespace Decorator.Inventories;

public class ClothesInventory(Inventory inventory = null) : Inventory()
{
    public override string Equip(string text)
    {
        return "Clothes " + text + " Equipped";
    }
}