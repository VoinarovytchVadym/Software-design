using Lab_2.task_5.Characters;

namespace Lab_2.task_5.Builders;

internal abstract class Builder : ICharacter, IClassedCharacter
{
    protected Character Character = new();

    private void _reset()
    {
        this.Character = new Character();
    }

    public IClassedCharacter ClassIs(string classs)
    {
        this.Character.Class = classs;
        return this;
    }

    public IClassedCharacter HeightIs(int height)
    {
        this.Character.Height = height;
        return this;
    }

    public IClassedCharacter PhysiqueIs(string physique)
    {
        this.Character.Physique = physique;
        return this;
    }

    public IClassedCharacter HairColorIs(string hairColor)
    {
        this.Character.HairColor = hairColor;
        return this;
    }

    public IClassedCharacter EyeColorIs(string eyeColor)
    {
        this.Character.EyeColor = eyeColor;
        return this;
    }

    public IClassedCharacter ClothesAre(string clothes)
    {
        this.Character.Clothes = clothes;
        return this;
    }

    public IClassedCharacter InventoryIs(string[]? inventory)
    {
        this.Character.Inventory = inventory;
        return this;
    }

    public abstract IClassedCharacter SetSpecial(string? special);

    public Character CreateCharacter()
    {
        Character character = this.Character;
        this._reset();
        return character;
    }
}