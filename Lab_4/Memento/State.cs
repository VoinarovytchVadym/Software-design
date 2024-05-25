namespace Memento;

public class State
{
    private readonly Stack<TextDocument> _history = new();

    public void Save(TextDocument document)
    {
        var version = new TextDocument(document.Content);
        _history.Push(version);
    }

    public TextDocument Undo()
    {
        if (_history.Count > 0)
        {
            _history.Pop();
        }
        return _history.Count > 0 ? _history.Peek() : new TextDocument("");
    }
}