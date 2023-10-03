using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> steel = new Dictionary<string, int>();
        Dictionary<string, int> carbon = new Dictionary<string, int>();
        Dictionary<string, int> swordValues = new Dictionary<string, int>
        {
            { "Gladius", 70 },
            { "Shamshir", 80 },
            { "Katana", 90 },
            { "Sabre", 110 },
            { "Broadsword", 150 }
        };

        int totalSwords = 0;

        foreach (var value in Console.ReadLine().Split(' ').Select(int.Parse))
        {
            if (!steel.ContainsKey(value.ToString()))
                steel[value.ToString()] = 0;
            steel[value.ToString()]++;
        }

        foreach (var value in Console.ReadLine().Split(' ').Select(int.Parse))
        {
            if (!carbon.ContainsKey(value.ToString()))
                carbon[value.ToString()] = 0;
            carbon[value.ToString()]++;
        }

        foreach (var pair in swordValues.ToList())
        {
            while (steel.ContainsKey(pair.Key) && carbon.ContainsKey(pair.Key))
            {
                totalSwords++;
                steel[pair.Key]--;
                carbon[pair.Key]--;
                if (steel[pair.Key] == 0)
                {
                    steel.Remove(pair.Key);
                }
                if (carbon[pair.Key] == 0)
                {
                    carbon.Remove(pair.Key);
                }
            }
        }

        foreach (var pair in carbon.ToList())
        {
            int value = int.Parse(pair.Key) + 5;
            if (!carbon.ContainsKey(value.ToString()))
            {
                carbon[value.ToString()] = 0;
            }
            carbon[value.ToString()] += pair.Value;
        }

        Console.WriteLine(totalSwords > 0 ? $"You have forged {totalSwords} swords." : "You did not have enough resources to forge a sword.");

        Console.WriteLine($"Steel left: {(steel.Count == 0 ? "none" : string.Join(", ", steel.Keys))}");
        Console.WriteLine($"Carbon left: {(carbon.Count == 0 ? "none" : string.Join(", ", carbon.Keys))}");

        foreach (var pair in swordValues.OrderBy(s => s.Key))
        {
            if (totalSwords > 0 && pair.Value > 0)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}