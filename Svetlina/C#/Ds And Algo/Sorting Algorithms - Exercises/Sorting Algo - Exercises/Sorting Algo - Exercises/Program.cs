using System;
using System.Linq;

namespace Sorting_Algo
{
    public class Program
    {
        void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 7, 6, 5, 4, 3, 2, 1 };
            Program ob = new Program();
            ob.sort(arr);
            printArray(arr);
        }
    }
}
