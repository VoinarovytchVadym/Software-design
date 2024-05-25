namespace Lab_2.task_5.Characters;

public class Character
{
    public string? Class { get; set; } = "Default";
    public int? Height { get; set; } = null;
    public string? Physique { get; set; } = "Default";
    public string? HairColor { get; set; } = "Default";
    public string? EyeColor { get; set; } = "Default";
    public string? Clothes { get; set; } = "Default";
    public string[]? Inventory { get; set; } = null;
    public string? Special { get; set; } = "Default";
    public override string ToString()
    {
        string inventoryInfo = Inventory is { Length: > 0 } ? string.Join(", ", Inventory) : "Empty";
        return $"-----------------------------\n" +
               $"Class: {Class}\n" +
               $"Height: {Height}\n" +
               $"Physique: {Physique}\n" +
               $"HairColor: {HairColor}\n" +
               $"EyeColor: {EyeColor}\n" +
               $"Clothes: {Clothes}\n" +
               $"Inventory: {inventoryInfo}\n" +
               $"Special: {Special}\n" +
               $"-----------------------------\n";
    }
}