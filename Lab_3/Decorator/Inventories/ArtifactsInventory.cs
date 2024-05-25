namespace Decorator.Inventories;

public class ArtifactsInventory(Inventory inventory = null) : Inventory()
{
    public override string Equip(string text)
    {
        return "Artifact " + text + " Equipped";
    }
}