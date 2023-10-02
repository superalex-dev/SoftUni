using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<char> message = new Stack<char>();
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '*')
            {
                if (message.Count > 0)
                    message.Pop();
            }
            else
            {
                message.Push(input[i]);
            }
        }

        int messageLength = message.Count;

        for (int i = 0; i < messageLength; i++)
        {
            Console.Write(message.Pop());
        }
    }
}
