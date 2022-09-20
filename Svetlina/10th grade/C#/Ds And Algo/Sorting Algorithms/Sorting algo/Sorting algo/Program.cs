using System;
using System.Linq;

namespace Sorting_algo
{
    public class Program
    {
        private static int[] auxArr;

        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Program ob = new Program();
            ob.Sort(arr, 0, arr.Length - 1);

            print(arr);
        }
        void Merge(int[] arr, int leftIndex, int midIndex, int rightIndex)
        {

            int n1 = midIndex - leftIndex + 1;
            int n2 = rightIndex - midIndex;


            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;


            for (i = 0; i < n1; ++i)
            {
                L[i] = arr[leftIndex + i];
            }
            for (j = 0; j < n2; ++j)
            {
                R[j] = arr[midIndex + 1 + j];
            }

            i = 0;
            j = 0;

            int k = leftIndex;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        private void Sort(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {

                int midIndex = leftIndex + (rightIndex - leftIndex) / 2;


                Sort(arr, leftIndex, midIndex);
                Sort(arr, midIndex + 1, rightIndex);
                Merge(arr, leftIndex, midIndex, rightIndex);
            }
        }


        static void print(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
