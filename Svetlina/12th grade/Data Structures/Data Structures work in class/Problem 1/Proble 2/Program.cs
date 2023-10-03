using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Stack<int> foodPortions = new Stack<int>(Console.ReadLine().Split(',').Select(int.Parse));
        Queue<int> staminaQuantities = new Queue<int>(Console.ReadLine().Split(',').Select(int.Parse));

        Dictionary<string, int> peaks = new Dictionary<string, int>
        {
            {"Vihren", 80},
            {"Kutelo", 90},
            {"Banski Suhodol", 100},
            {"Polezhan", 60},
            {"Kamenitza", 70}
        };

        Queue<string> conqueredPeaks = new Queue<string>();

        foreach (var peak in peaks)
        {
            while (foodPortions.Count > 0 && staminaQuantities.Count > 0)
            {
                int sum = foodPortions.Pop() + staminaQuantities.Dequeue();

                if (sum >= peak.Value)
                {
                    conqueredPeaks.Enqueue(peak.Key);
                    break;
                }
            }
        }

        if (conqueredPeaks.Count == peaks.Count)
        {
            Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
        }
        else
        {
            Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
        }

        if (conqueredPeaks.Count > 0)
        {
            Console.WriteLine("Conquered peaks:");
            while (conqueredPeaks.Count > 0)
            {
                Console.WriteLine(conqueredPeaks.Dequeue());
            }
        }
    }
}
