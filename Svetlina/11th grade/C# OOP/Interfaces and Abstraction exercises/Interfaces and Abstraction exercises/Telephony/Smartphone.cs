namespace Telephony;

public class Smartphone : ICallable, IBrowsable
{
    public void Call(string number)
    {
        if (number.Length == 10 && number.All(char.IsDigit))
        {
            Console.WriteLine($"Calling... {number}");
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }

    public void Browse(string url)
    {
        if (url.Any(char.IsDigit))
        {
            Console.WriteLine("Invalid URL!");
        }
        else
        {
            Console.WriteLine($"Browsing: {url}!");
        }
    }
}