using System.Runtime.InteropServices.JavaScript;

namespace Lab_2.task_3;

sealed class Authenticator
{
    private static Authenticator? _authenticator;
    private static object _refObj = new object();

    private Authenticator()
    {
        Console.WriteLine("Authenticated successfully");
    }

    public static Authenticator GetInstance()
    {
        if (_authenticator == null)
        {
            lock (_refObj)
            {
                _authenticator ??= new Authenticator();
            }
        }
        return _authenticator;
    }
}