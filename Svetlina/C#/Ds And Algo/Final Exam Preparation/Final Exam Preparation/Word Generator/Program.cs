using System;
using System.Linq;

namespace Word_Generator
{
    public class Program
    {
        static char[] arr;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            arr = new char[n];

            WordGenerator(n, 0);
        }

        private static void WordGenerator(int n, int current)
        {
            if (current >= n)
            {
                Console.WriteLine(String.Join("", arr));
                return;
            }

            for (int i = 97; i < 97 + n; i++)
            {
                arr[current] = (char)i;
                WordGenerator(n, current + 1);
            }
        }
    }
}
