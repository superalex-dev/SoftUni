namespace Telephony;

public class StationaryPhone
{
    public void Call(string number)
    {
        if (number.Length == 7 || number.All(char.IsDigit))
        {
            Console.WriteLine($"Dialing... {number}");
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}