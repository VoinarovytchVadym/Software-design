using Bridge.Renderers;
using Bridge.Shapes;

namespace Bridge;

static class Program
{
    public static void Main()
    {
        IRenderer rasterRenderer = new RasterRenderer();
        IRenderer vectorRenderer = new VectorRenderer();

        
        Shape circle = new Circle(rasterRenderer);
        circle.Draw();

        Shape square = new Square(vectorRenderer);
        square.Draw();

        Shape triangle = new Triangle(rasterRenderer);
        triangle.Draw();
    }
}