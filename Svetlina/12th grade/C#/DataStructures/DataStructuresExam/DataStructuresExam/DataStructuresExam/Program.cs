using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 3, 0, 1 };
        int missingNumber = FindNumber(nums);
        Console.WriteLine(missingNumber);
        int[] nums2 = { 0, 1 };
        Console.WriteLine(FindNumber(nums2));

        int[] nums3 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
        Console.WriteLine(FindNumber(nums3));
    }

    public static int FindNumber(int[] nums)
    {
        int n = nums.Length;
        int total = n * (n + 1) / 2;

        for (int i = 0; i < n; i++)
        {
            total -= nums[i];
        }

        return total;
    }
}
