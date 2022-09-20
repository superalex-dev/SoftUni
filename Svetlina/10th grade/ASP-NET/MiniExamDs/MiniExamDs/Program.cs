using System;
using System.Globalization;
using System.Threading;
using Wintellect.PowerCollections;


namespace MiniExamDs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            OrderedDictionary<string, string> companies = new OrderedDictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] CompaniesTokens = Console.ReadLine().Split(" | ");
                string companiesName = CompaniesTokens[0];
                string owner = CompaniesTokens[1];
                companies.Add(owner, companiesName);
            }

            string[] letterTokens = Console.ReadLine().Split(" | ");
            string firstletter = "A";
            string lastletter = "P";
            var companiesByOwner = companies.Range(firstletter, true, lastletter, true);

            foreach (var o in companiesByOwner)
            {
                Console.WriteLine($"{o.Key} - {o.Value}");
            }
        }
    }
}
