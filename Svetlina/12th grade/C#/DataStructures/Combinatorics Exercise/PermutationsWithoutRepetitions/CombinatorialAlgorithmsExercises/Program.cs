using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var elements = new List<string> { "A", "B", "C" };
        var permutations = Permute(elements, 0, elements.Count - 1);

        foreach (var perm in permutations)
        {
            Console.WriteLine(string.Join(" ", perm));
        }
    }

    private static List<List<T>> Permute<T>(List<T> elements, int start, int end)
    {
        var result = new List<List<T>>();

        if (start == end)
        {
            result.Add(new List<T>(elements));
        }
        else
        {
            for (int i = start; i <= end; i++)
            {
                Swap(elements, start, i);
                result.AddRange(Permute(new List<T>(elements), start + 1, end));
                Swap(elements, start, i); // backtrack
            }
        }

        return result;
    }

    private static void Swap<T>(List<T> elements, int i, int j)
    {
        T temp = elements[i];
        elements[i] = elements[j];
        elements[j] = temp;
    }
}