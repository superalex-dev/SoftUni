using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine().Trim();

        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                stack.Push(c);
            }
            else if (c == '*')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
        }

        StringBuilder sb = new StringBuilder();
        foreach (var character in stack)
        {
            sb.Append(character);
        }

        Console.WriteLine(sb.ToString());
    }
}
