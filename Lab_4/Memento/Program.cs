namespace Memento;

internal abstract class Program
{
    private static void Main()
    {
        var textEditor = new TextEditor();
        
        textEditor.Set("Hello world!");
        textEditor.Save(); 
        Console.WriteLine("version-1: " + textEditor.Get());

        textEditor.Set("Hello world!!!!");
        textEditor.Save();
        Console.WriteLine("version-2: " + textEditor.Get());
        
        textEditor.Undo();
        Console.WriteLine("Undo to version-1: " + textEditor.Get());
        
        
    }
}