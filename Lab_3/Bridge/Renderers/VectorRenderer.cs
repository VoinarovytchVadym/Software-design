namespace Bridge.Renderers;

public class VectorRenderer : IRenderer
{
    public void RenderShapeAs(string shape)
    {
        Console.WriteLine($"Drawing {shape} as vectors");
    }
}