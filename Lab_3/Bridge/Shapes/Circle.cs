using Bridge.Renderers;

namespace Bridge.Shapes;

public class Circle(IRenderer renderer) : Shape(renderer)
{
    public override void Draw()
    {
        renderer.RenderShapeAs("Circle");
    }
}