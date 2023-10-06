using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    private static List<string> data = new List<string> { "o", "o", "x", "o", "o" };

    private static object locker = new object();

    static void Main()
    {
        Thread forwardThread = new Thread(Forward);
        forwardThread.Start();

        Thread backThread = new Thread(Back);
        backThread.Start();
        forwardThread.Join();
        backThread.Join();
    }

    private static void Forward()
    {
        Thread.Sleep(50);
        lock (locker)
        {
            data[4] = "f";
            PrintList();
        }
    }

    private static void Back()
    {
        Thread.Sleep(100);
        lock (locker)
        {
            data[4] = "o";
            data[1] = "b";
            PrintList();
        }
    }

    private static void PrintList()
    {
        foreach (string s in data)
        {
            Console.Write(s + " ");
        }
        Console.WriteLine();
    }
}