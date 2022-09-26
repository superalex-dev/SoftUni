using System;
using System.Collections.Generic;

namespace entrance_exam_prep
{
    public class Graph
    {
        public List<int>[] AdjacencyList { get; set; }
        public int Vertices { get; set; }
        public int Edges { get; set; }

        public Graph(int vertices, int edges)
        {
            Vertices = vertices;
            Edges = edges;
            AdjacencyList = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
            {
                AdjacencyList[i] = new List<int>();
            }
        }

        public void AddEdge(int source, int destination)
        {
            AdjacencyList[source].Add(destination);
            AdjacencyList[destination].Add(source);
        }

        public bool IsCyclic()
        {
            var visited = new bool[Vertices];
            var recStack = new bool[Vertices];
            for (int i = 0; i < Vertices; i++)
            {
                if (!visited[i])
                {
                    if (IsCyclicUtil(i, visited, recStack))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool IsCyclicUtil(int vertex, bool[] visited, bool[] recStack)
        {
            if (recStack[vertex])
            {
                return true;
            }
            if (visited[vertex])
            {
                return false;
            }
            visited[vertex] = true;
            recStack[vertex] = true;
            foreach (var neighbour in AdjacencyList[vertex])
            {
                if (IsCyclicUtil(neighbour, visited, recStack))
                {
                    return true;
                }
            }
            recStack[vertex] = false;
            return false;
        }

        public void ReadGraph()
        {
            for (int i = 0; i < Edges; i++)
            {
                var neighbours = Console.ReadLine().Split('-');
                AddEdge(int.Parse(neighbours[0]), int.Parse(neighbours[1]));
            }
        }
    }
}