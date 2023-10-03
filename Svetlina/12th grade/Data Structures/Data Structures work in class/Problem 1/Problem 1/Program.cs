using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> bombEffects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
        Stack<int> bombCasings = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));

        Dictionary<string, int> bombs = new Dictionary<string, int>
        {
            {"Datura Bombs", 0},
            {"Cherry Bombs", 0},
            {"Smoke Decoy Bombs", 0}
        };

        while (bombEffects.Count > 0 && bombCasings.Count > 0)
        {
            int effect = bombEffects.Peek();
            int casing = bombCasings.Peek();
            int sum = effect + casing;

            if (sum == 40 || sum == 60 || sum == 120)
            {
                switch (sum)
                {
                    case 40: bombs["Datura Bombs"]++; break;
                    case 60: bombs["Cherry Bombs"]++; break;
                    case 120: bombs["Smoke Decoy Bombs"]++; break;
                }

                bombEffects.Dequeue();
                bombCasings.Pop();
            }
            else
            {
                bombCasings.Pop();
                bombCasings.Push(casing - 5);
            }

            if (bombs["Datura Bombs"] >= 3 && bombs["Cherry Bombs"] >= 3 && bombs["Smoke Decoy Bombs"] >= 3)
            {
                break;
            }
        }

        if (bombs["Datura Bombs"] >= 3 && bombs["Cherry Bombs"] >= 3 && bombs["Smoke Decoy Bombs"] >= 3)
        {
            Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
        }
        else
        {
            Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
        }

        Console.WriteLine(bombEffects.Any() ? $"Bomb Effects: {string.Join(", ", bombEffects)}" : "Bomb Effects: empty");
        Console.WriteLine(bombCasings.Any() ? $"Bomb Casings: {string.Join(", ", bombCasings)}" : "Bomb Casings: empty");

        foreach (var bomb in bombs.OrderBy(b => b.Key))
        {
            Console.WriteLine($"{bomb.Key}: {bomb.Value}");
        }
    }
}