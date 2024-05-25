namespace Bridge.Renderers;

public class RasterRenderer : IRenderer
{
    public void RenderShapeAs(string shape)
    {
        Console.WriteLine($"Drawing {shape} as pixels");
    }
}