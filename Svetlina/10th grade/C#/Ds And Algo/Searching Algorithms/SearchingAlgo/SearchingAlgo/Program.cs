using System;
using System.Linq;

namespace SearchingAlgo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine() is string ? Console.ReadLine().Split(" ")
            .Select(int.Parse)
            .ToArray() is int[] arrMain ? Console.ReadLine().Split(" ")
            .Select(int.Parse)
            .ToArray() is int[] needles ? 
            String.Join(" ", 
                needles.Select(x => 
                    arrMain.Select((y, i) => 
                        (y == 0 && x <= arrMain.Where((z, o) => (o >= i && z != 0)).FirstOrDefault()) || 
                        (y !=0 && x <= y) ? i : i == arrMain.Length - 1 ? i+1 : -10).FirstOrDefault(y => y > -10))) : "" : "" : "");
        }
    }
}
