namespace Lab_2.task_4;

public static class VirusCloningUtility
{
    public static T PerformCopy<T>(this IVirus<T> virus)
        where T : new()
    {
        return virus.PerformCopy();
    }
}