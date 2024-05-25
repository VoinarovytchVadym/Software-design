using Bridge.Renderers;

namespace Bridge.Shapes;

public abstract class Shape(IRenderer renderer)
{
    protected IRenderer Renderer;
    public abstract void Draw();
}