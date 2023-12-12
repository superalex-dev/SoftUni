using System;
using System.Numerics;

class Program
{
    public static void Main()
    {
        int n = 15;
        Console.WriteLine(CalculateFibonacci(n));
    }

    public static BigInteger CalculateFibonacci(int n)
    {
        if (n == 0 || n == 1)
        {
            return n;
        }

        return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
    }
}
