namespace Lab_2.task_5.Characters;

public interface IClassedCharacter
{
    IClassedCharacter HeightIs(int height);
    IClassedCharacter PhysiqueIs(string physique);
    IClassedCharacter HairColorIs(string hairColor);
    IClassedCharacter EyeColorIs(string eyeColor);
    IClassedCharacter ClothesAre(string clothes);
    IClassedCharacter InventoryIs(string[]? inventory);
    IClassedCharacter SetSpecial(string? special);
    Character CreateCharacter();
}