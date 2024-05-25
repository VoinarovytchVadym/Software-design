using Bridge.Renderers;

namespace Bridge.Shapes;

public class Triangle(IRenderer renderer) : Shape(renderer)
{
    public override void Draw()
    { 
        renderer.RenderShapeAs("Triangle");
    }
}