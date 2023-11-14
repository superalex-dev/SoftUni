using System;
using System.Collections.Generic;

public class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        HashSet<string> srcCities = new HashSet<string>();
        HashSet<string> destCities = new HashSet<string>();

        foreach (var path in paths)
        {
            srcCities.Add(path[0]);
            destCities.Add(path[1]);
        }

        foreach (var city in destCities)
        {
            if (!srcCities.Contains(city))
            {
                return city;
            }
        }

        return "";
    }
}

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var paths = new List<IList<string>> {
            new List<string> { "London", "New York" },
            new List<string> { "New York", "Lima" },
            new List<string> { "Lima", "Sao Paulo" }
        };
        Console.WriteLine(solution.DestCity(paths));
    }
}
