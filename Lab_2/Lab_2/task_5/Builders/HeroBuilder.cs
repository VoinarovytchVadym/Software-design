using Lab_2.task_5.Characters;

namespace Lab_2.task_5.Builders;

public abstract class HeroBuilder 
{
    public static ICharacter Create()
    {
        return new Hero();
    }
    
    private class Hero : Builder
    {
        public override IClassedCharacter SetSpecial(string? special)
        {
            this.Character.Special = special != null ? $"Immunity to holy damage & {special}" : "Immunity to holy damage";
            return this;
        }
    }
}