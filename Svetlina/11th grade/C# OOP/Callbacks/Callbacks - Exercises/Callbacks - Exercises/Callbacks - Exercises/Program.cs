using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] names = input.Split(' ');

            PrintNames(names, Console.WriteLine);
        }
        static void PrintNames(IEnumerable<string> names, Action<string> printAction)
        {
            foreach (var name in names)
            {
                printAction(name);
            }
        }
    }
}