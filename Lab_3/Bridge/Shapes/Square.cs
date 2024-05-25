using Bridge.Renderers;

namespace Bridge.Shapes;

public class Square(IRenderer renderer) : Shape(renderer)
{
    public override void Draw()
    { 
        renderer.RenderShapeAs("Square");
    }
}