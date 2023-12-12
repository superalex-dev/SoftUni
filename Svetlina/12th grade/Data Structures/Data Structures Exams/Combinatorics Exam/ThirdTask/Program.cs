namespace ThirdTask
{
    public class Program
    {
        private static int rowCount;
        private static int colCount;
        private static char[,] matrix; 
        private static bool[,] visited;

        public static void Main(string[] args)
        {
            rowCount = 4;
            colCount = 6;
            matrix = new char[,] {
                { 't', 't', 't', 't', 't', 't' },
                { 't', 't', 'd', 'd', 'd', 't' },
                { 't', 'd', 't', 'd', 'd', 't' },
                { 't', 'd', 'd', 't', 'd', 't' }
            };
            visited = new bool[rowCount, colCount];

            int connectedTunnels = CountConnectedTunnels();
            Console.WriteLine(connectedTunnels);
        }

        private static int CountConnectedTunnels()
        {
            int count = 0;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (matrix[i, j] == 't' && !visited[i, j])
                    {
                        DFS(i, j);
                        count++;
                    }
                }
            }
            return count;
        }

        private static void DFS(int row, int col)
        {
            if (row < 0 || col < 0 || row >= rowCount || col >= colCount || matrix[row, col] != 't' || visited[row, col])
            {
                return;
            }

            visited[row, col] = true;

            DFS(row + 1, col); //nadolu
            DFS(row - 1, col); //nagore
            DFS(row, col + 1); //nadqsno
            DFS(row, col - 1); //nalqvo
        }
    }
}