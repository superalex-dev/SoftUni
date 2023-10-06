using System;
using System.Threading;

namespace Even_Numbers
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            Thread evenNumberThread = new Thread(() => PrintEvenNumbers(start, end));
            evenNumberThread.Start();

            evenNumberThread.Join();

            Console.WriteLine("Thread finished work");
        }

        private static void PrintEvenNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
