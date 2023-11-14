using System;

namespace ThreadSynchronization
{
    class Program
    {
        private static readonly object locker = new object();
        static void Main(string[] args)
        {

        }

        public static void Print()
        {
            Monitor.Enter(locker);
            try
            {
                Console.WriteLine("Thread entered into the critical section.");
                for (int num = 0; num <= 2; num++)
                {
                    Console.WriteLine();
                }
            }
            finally
            {
                Monitor.Exit(locker);
            }   
        }
    }
}