using System;
using System.Linq;

namespace Inversion_count
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(MergeSort(arr));
        }
        private static int MergeSort(int[] arr)
        {
            int[] temp = new int[arr.Length];
            return Sort(arr, temp, 0, arr.Length - 1);
        }
        private static int Sort(int[] arr, int[] temp, int left, int right)
        {
            int mid, invCount = 0;

            if (right > left)
            {
                mid = (right + left) / 2;

                invCount = Sort(arr, temp, left, mid);
                invCount += Sort(arr, temp, mid + 1, right);

                invCount += Merge(arr, temp, left, mid + 1, right);
            }

            return invCount;
        }
        private static int Merge(int[] arr, int[] temp, int left, int mid, int right)
        {
            int leftIndex, rightIndex, currIndex;

            int invCount = 0;

            leftIndex = left;
            rightIndex = mid;
            currIndex = left;

            while ((leftIndex <= mid - 1) && (rightIndex <= right))
            {
                if (arr[leftIndex] <= arr[rightIndex])
                {
                    temp[currIndex++] = arr[leftIndex++];
                }

                else
                {
                    temp[currIndex++] = arr[rightIndex++];
                    invCount += mid - leftIndex;
                }
            }

            while (leftIndex <= mid - 1)
            {
                temp[currIndex++] = arr[leftIndex++];
            }


            while (rightIndex <= right)
            {
                temp[currIndex++] = arr[rightIndex++];
            }


            for (leftIndex = left; leftIndex <= right; leftIndex++)
            {
                arr[leftIndex] = temp[leftIndex];
            }

            return invCount;
        }
    }
}
