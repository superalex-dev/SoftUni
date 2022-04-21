using System;
using System.Collections.Generic;
using System.Linq;

namespace Graph_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfVertex = int.Parse(Console.ReadLine());
            List<int>[] graph = new List<int>[numberOfVertex];

            //Create edges | Read Graph
            for (int i = 0; i < numberOfVertex; i++)
            {
                int currentVertex = i;
                graph[currentVertex] = new List<int>();
                string input = Console.ReadLine();
                if (input.Length > 0)
                {
                    int[] currentEgdes = input.Split().Select(int.Parse).ToArray();
                    foreach (var edge in currentEgdes)
                    {
                        graph[currentVertex].Add(edge);
                    }
                }
            }

            //Algo --- 
            bool[] visited = new bool[numberOfVertex];
            for (int vertex = 0; vertex < numberOfVertex; vertex++)
            {
                if (visited[vertex])
                {
                    continue;
                }
                Console.Write("Connected component: ");
                DFS(visited, vertex, graph);
                Console.WriteLine();
            }
        }

        private static void DFS(bool[] visited, int vertex, List<int>[] gr)
        {
            if (visited[vertex])
            {
                return;
            }

            visited[vertex] = true;
            if (gr[vertex].Count > 0)
            {
                foreach (var adjacent in gr[vertex])
                {
                    DFS(visited, adjacent, gr);
                }
            }

            Console.Write(vertex + " ");
        }
    }
}
