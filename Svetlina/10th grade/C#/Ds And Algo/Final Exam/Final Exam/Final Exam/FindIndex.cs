using System;
using System.Linq;

namespace FindIndex
{
    public class FindIndex
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ")
                .ToArray();

            string searchIndex = Console.ReadLine();

            names = names.Concat(new string[] { searchIndex })
                .ToArray();
            BubbleSort(names, names.Length);

            Console.WriteLine(Array.IndexOf(names, searchIndex));
        }

        private static void BubbleSort(string[] arr, int length)
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int k = i + 1; k < length; k++)
                {
                    if (arr[i].CompareTo(arr[k]) > 0)
                    {
                        string a;
                        a = arr[i];
                        arr[i] = arr[k];
                        arr[k] = a;
                    }
                }
            }
        }
    }
}