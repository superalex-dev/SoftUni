using System;
using System.Linq;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread checkThread = new Thread(CheckForNumbers);
        checkThread.Start();
        checkThread.Join();
    }

    private static void CheckForNumbers()
    {
        string input = Console.ReadLine();

        try
        {
            if (input.Any(char.IsDigit))
            {
                throw new ArgumentException("Boom");
            }
            else
            {
                Console.WriteLine("There are no bombs in the text.");
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}