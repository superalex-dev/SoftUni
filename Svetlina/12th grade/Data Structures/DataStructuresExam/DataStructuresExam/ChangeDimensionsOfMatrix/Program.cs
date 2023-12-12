using System;

namespace FindTheSumOfLeftLeavesInBt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mat1 = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
            int[][] reshapedMat1 = ChangeDimensionsOfMatrix(mat1, 1, 4);
            PrintMatrix(reshapedMat1);


            int[][] mat2 = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
            int[][] reshapedMat2 = ChangeDimensionsOfMatrix(mat2, 2, 2);
            PrintMatrix(reshapedMat2);
        }
        public static int[][] ChangeDimensionsOfMatrix(int[][] mat, int r, int c)
        {
            int m = mat.Length;
            int n = mat[0].Length;

            if (m * n != r * c)
            {
                return mat;
            }

            int[][] result = new int[r][];
            for (int i = 0; i < r; i++)
            {
                result[i] = new int[c];
            }

            int row = 0;
            int col = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    result[row][col] = mat[i][j];
                    col++;

                    if (col == c)
                    {
                        row++;
                        col = 0;
                    }
                }
            }
            return result;
        }

        static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}