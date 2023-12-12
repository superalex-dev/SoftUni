namespace Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result1 = GenerateCombinations(4, 2);
            PrintResult(result1);

            var result2 = GenerateCombinations(1, 1);
            PrintResult(result2);
        }

        public static List<List<int>> GenerateCombinations(int n, int k)
        {
            var results = new List<List<int>>();
            Backtrack(1, new List<int>(), results, n, k);
            return results;
        }

        private static void Backtrack(int start, List<int> current, List<List<int>> results, int n, int k)
        {
            if (current.Count == k)
            {
                results.Add(new List<int>(current));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                current.Add(i);
                Backtrack(i + 1, current, results, n, k);
                current.RemoveAt(current.Count - 1); // backtrack
            }
        }

        private static void PrintResult(List<List<int>> results)
        {
            foreach (var combination in results)
            {
                Console.WriteLine("[" + string.Join(", ", combination) + "]");
            }
            Console.WriteLine();
        }
    }
}
