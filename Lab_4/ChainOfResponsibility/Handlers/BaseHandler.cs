namespace Lab_4;

public abstract class BaseHandler
{
    private BaseHandler? _next;

    public BaseHandler SetNextHandler(BaseHandler next)
    {
        this._next = next;
        return next;
    }

    public abstract void Handle();

    protected void HandleNext()
    {
        if (this._next == null)
        {
            Console.WriteLine("Будьласка зверніться в службу підтримки *email.");
        }
        else
        {
            this._next.Handle();
        }
    }

    protected string Input()
    {
        string input = Console.ReadLine();
        while (true)
        {
            if (input == "1" || input == "0")
            {
                return input;
            }

            return Input();
        }
    }
}