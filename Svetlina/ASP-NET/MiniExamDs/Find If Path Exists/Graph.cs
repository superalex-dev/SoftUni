using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_If_Path_Exists
{
	public class Graph
	{
		private int verticesCount;
		private List<int>[] adjacentsList;

		public Graph(int vertices)
		{
			this.verticesCount = vertices;
			adjacentsList = new List<int>[verticesCount];

			for (int i = 0; i < verticesCount; i++)
			{
				adjacentsList[i] = new List<int>();
			}
		}

		public void AddEdge(int firstVertex, int secondVertex)
		{
			adjacentsList[firstVertex].Add(secondVertex);
			adjacentsList[secondVertex].Add(firstVertex);
		}

		public void FindShortestPath(int start, int end)
		{
			bool[] isVisited = new bool[verticesCount];
			List<int> pathList = new List<int>();

			pathList.Add(start);
			int count = 0;

		}

		public static void Main()
		{
			var graph = ReadGraph();

			int startVertex = int.Parse(Console.ReadLine());
			int endVertex = int.Parse(Console.ReadLine());

			Console.WriteLine($"Path from {startVertex} to {endVertex} is found");
			graph.FindShortestPath(startVertex, endVertex);
		}

		private static Graph ReadGraph()
		{
			int verticesCount = int.Parse(Console.ReadLine());
			Graph graph = new Graph(verticesCount);

			int edgesCount = int.Parse(Console.ReadLine());
			for (int i = 0; i < edgesCount; i++)
			{
				int[] edgeArr = Console.ReadLine()
					.Split(" ").Select(int.Parse).ToArray();
				graph.AddEdge(edgeArr[0], edgeArr[1]);
			}

			return graph;
		}
	}
}
