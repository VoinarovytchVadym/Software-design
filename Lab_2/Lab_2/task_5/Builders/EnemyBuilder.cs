using Lab_2.task_5.Characters;

namespace Lab_2.task_5.Builders;

public abstract class EnemyBuilder
{
    public static ICharacter Create()
    {
        return new Enemy();
    }

    private class Enemy : Builder
    {
        public override IClassedCharacter SetSpecial(string? special)
        {
            this.Character.Special = special != null ? $"Immunity to evil damage & {special}" : "Immunity to evil damage";
            return this;
        }
    }
}