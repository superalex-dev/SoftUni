namespace Permutations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new int[] { 1, 2, 3 };
            var result1 = Permute(nums1);
            PrintResult(result1);

            var nums2 = new int[] { 0, 1 };
            var result2 = Permute(nums2);
            PrintResult(result2);

            var nums3 = new int[] { 1 };
            var result3 = Permute(nums3);
            PrintResult(result3);
        }

        public static IList<IList<int>> Permute(int[] nums)
        {
            var results = new List<IList<int>>();
            Permute(nums, 0, results);
            return results;
        }

        private static void Permute(int[] nums, int start, IList<IList<int>> results)
        {
            if (start == nums.Length)
            {
                results.Add(new List<int>(nums));
            }
            else
            {
                for (int i = start; i < nums.Length; i++)
                {
                    Swap(nums, start, i);
                    Permute(nums, start + 1, results);
                    Swap(nums, start, i); // backtrack
                }
            }
        }

        private static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        private static void PrintResult(IList<IList<int>> results)
        {
            foreach (var list in results)
            {
                Console.WriteLine("[" + string.Join(", ", list) + "]");
            }
            Console.WriteLine();
        }
    }
}
