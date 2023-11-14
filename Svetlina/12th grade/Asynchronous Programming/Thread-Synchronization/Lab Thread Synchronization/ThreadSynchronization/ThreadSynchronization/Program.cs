using System;

namespace ThreadSynchronization
{
    class Program
    {
        public static int counter;
        public static object locker = new object();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(PrintStar);
            t1.Start();
            Thread t2 = new Thread(PrintPlus);
            t2.Start();
        }

        static void PrintStar()
        {
            lock (locker)
            {
                for (counter = 0; counter < 5; counter++)
                {
                    Console.WriteLine(" * ");
                }
            }
        }

        static void PrintPlus()
        {
            lock (locker)
            {
                for (counter = 0; counter < 5; counter++)
                {
                    Console.WriteLine(" + ");
                }
            }
        }
    }
}