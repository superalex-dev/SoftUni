using System;
using System.Threading;

namespace Print_Symbol
{
    class Program
    {
        private const int PrintCount = 450;

        static void Main()
        {
            Thread oThread = new Thread(() => Go('O'));
            oThread.Start();

            Go('x');

            oThread.Join();
        }

        static void Go(char symbol)
        {
            for (int i = 0; i < PrintCount; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}
