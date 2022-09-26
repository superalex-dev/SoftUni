using System;

namespace entrance_exam_prep
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Graph graph = new Graph(n, m);
            graph.ReadGraph();

            Console.WriteLine(graph.IsCyclic());
        }
    }
}