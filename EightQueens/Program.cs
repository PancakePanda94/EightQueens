namespace EightQueens
{
    namespace EightQueens
    {
        internal class Program
        {
            const int N = 8;
            static void Main(string[] args)
            {
                int[,] tablero = new int[N, N];

                if (PlaceQueen(tablero, 0))
                {
                    PrintBoard(tablero);
                }
                else
                {
                    Console.WriteLine("No hay solución.");
                    PrintBoard(tablero);
                }

            }

            public static bool PlaceQueen(int[,] board, int line)
            {
                if (line == N)
                {
                    return true;
                }

                for (int i = 0; i < N; i++)
                {
                    if (IsSafe(board, i, line))
                    {
                        board[line, i] = 1;
                        if (PlaceQueen(board, line + 1))
                            return true;
                        board[line, i] = 0;
                    }

                }
                return false;
            }
            public static bool IsSafe(int[,] board, int column, int line)
            {
                //int i = 0, j = 0;
                for (int i = 0; i < N; i++)
                {
                    if (board[i, column] == 1)
                    {
                        return false;
                    }
                }
                //i = 0; j = 0;

                for (int i = line - 1, j = column - 1; i >= 0 && j >= 0; i--, j--)
                {
                    if (board[i, j] == 1)
                        return false;
                }

                for (int i = line - 1, j = column + 1; i >= 0 && j < N; i--, j++)
                {
                    if (board[i, j] == 1)
                        return false;
                }

                return true;
            }
            private static void PrintBoard(int[,] tablero)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        Console.Write(tablero[i, j] == 1 ? "Q " : ". ");
                    }
                    Console.WriteLine();
                }
            }
        }

    }

}
