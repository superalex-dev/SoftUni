namespace ValidSudoku
{
    internal class Program
    {

        public bool IsValidSudoku(char[][] board)
        {
            HashSet<string> seen = new HashSet<string>();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    char currentVal = board[i][j];

                    if (currentVal != '.')
                    {
                        string rowKey = $"{currentVal} in row {i}";
                        string colKey = $"{currentVal} in column {j}";
                        string boxKey = $"{currentVal} in box {i / 3}-{j / 3}";

                        if (seen.Contains(rowKey) || seen.Contains(colKey) || seen.Contains(boxKey))
                        {
                            return false;
                        }

                        seen.Add(rowKey);
                        seen.Add(colKey);
                        seen.Add(boxKey);
                    }
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Program validator = new Program();

            char[][] board1 = new char[][] {
            new char[] {'5','3','.','.','7','.','.','.','.'},
            new char[] {'6','.','.','1','9','5','.','.','.'},
            new char[] {'.','9','8','.','.','.','.','6','.'},
            new char[] {'8','.','.','.','6','.','.','.','3'},
            new char[] {'4','.','.','8','.','3','.','.','1'},
            new char[] {'7','.','.','.','2','.','.','.','6'},
            new char[] {'.','6','.','.','.','.','2','8','.'},
            new char[] {'.','.','.','4','1','9','.','.','5'},
            new char[] {'.','.','.','.','8','.','.','7','9'}
        };

            char[][] board2 = new char[][] {
            new char[] {'8','3','.','.','7','.','.','.','.'},
            new char[] {'6','.','.','1','9','5','.','.','.'},
            new char[] {'.','9','8','.','.','.','.','6','.'},
            new char[] {'8','.','.','.','6','.','.','.','3'},
            new char[] {'4','.','.','8','.','3','.','.','1'},
            new char[] {'7','.','.','.','2','.','.','.','6'},
            new char[] {'.','6','.','.','.','.','2','8','.'},
            new char[] {'.','.','.','4','1','9','.','.','5'},
            new char[] {'.','.','.','.','8','.','.','7','9'}
        };

            Console.WriteLine("Board 1 is valid: " + validator.IsValidSudoku(board1));
            Console.WriteLine("Board 2 is valid: " + validator.IsValidSudoku(board2));
        }
    }
}