using Composer;
using Composer.Nodes;

namespace LightWeight;

public static class MemoryCalculator
{
    public static long CalculateMemoryUsage(LightNode node)
    {
        long size = 0;

        size += System.GC.GetTotalMemory(false);

        size += CalculateNodeMemoryUsage(node);

        return size;
    }

    private static long CalculateNodeMemoryUsage(LightNode node)
    {
        long size = 0;

        switch (node)
        {
            case LightTextNode textNode:
                size += sizeof(char) * textNode.OuterHTML.Length;
                break;
            case LightElementNode elementNode:
            {
                size += sizeof(char) * elementNode.OuterHTML.Length;
                foreach (var child in elementNode.Childes)
                {
                    size += CalculateNodeMemoryUsage(child);
                }

                break;
            }
        }

        return size;
    }
}