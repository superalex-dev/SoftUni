using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] names = input.Split(' ');

            AppendSir(names, Console.WriteLine);
        }

        static void AppendSir(IEnumerable<string> names, Action<string> printAction)
        {
            foreach (var name in names)
            {
                printAction($"Sir {name}");
            }
        }
    }
}