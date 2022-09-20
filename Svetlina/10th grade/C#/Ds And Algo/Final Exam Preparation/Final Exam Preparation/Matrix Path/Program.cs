using System;
using System.Linq;

namespace Matrix_Path
{
    public class Program
    {
        static int[,] matrix;
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());

            ReadMatrix(h, w);

            bool isTherePath = SearchPath();
        }

        private static bool SearchPath()
        {
            Node current = new Node();
            current.Col = 0;
            current.Row = 0;
            current.Value = matrix[0,0];


            TryDirection(current)
            TryDirection(current, current.Row + 1, current.Col);


            return false;
        }

        private static void TryDirection(Node current, int nextRow, int nextCol)
        {
            if (nextRow< matrix.GetLength(0) && nextCol< matrix.GetLength(1) && current.Value<matrix[nextRow, nextCol])
            {
                current.Value = matrix[current.Row + 1, current.Col];
                current.Row = current.Row + 1;
            }
        }

        private static void ReadMatrix(int h, int w)
        {
            matrix = new int[h, w];
            for (int row = 0; row < h; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < w; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }

    class Node
    {
        public int Value { get; set; }
        public int Row { get; internal set; }
        public int Col { get; internal set; }
    }

}
