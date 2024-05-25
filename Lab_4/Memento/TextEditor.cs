namespace Memento;

public class TextEditor
{
    private TextDocument _document = new("");
    private readonly State _state = new();

    public void Save()
    {
        _state.Save(_document);
    }

    public void Undo()
    {
        _document = _state.Undo();
        Console.WriteLine("Undo successful. ");
    }

    public void Set(string content)
    {
        _document.Content = content;
    }

    public string Get()
    {
        return _document.Content;
    }
}