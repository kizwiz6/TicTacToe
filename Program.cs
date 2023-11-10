namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3, 3];

            for (int i = 0; i < 3; i++)
            {
                string line = Console.ReadLine();

                if (line.Length != 3)
                {
                    Console.WriteLine("Invalid input. Please enter exactly three characters");
                    return;
                }

                board[i, 0] = line[0];
                board[i, 1] = line[1];
                board[i, 2] = line[2];
            }

            if (winsTicTacToe(board, 'X'))
            {
                Console.WriteLine("X wins");
            }
            else if (winsTicTacToe(board, 'O'))
            {
                Console.WriteLine("O wins");
            }
            else
            {
                Console.WriteLine("Tie");
            }
        }

        static bool winsTicTacToe(char[,] board, char symbol)
        {
            // Check rows and columns
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == symbol && board[i, 1] == symbol && board[i, 2] == symbol) ||
                        board[0, 2] == symbol && board[2, 0] == symbol)
                {
                return true;
            }
        }
            // Check diagonals
        if (board[1, 1] == symbol &&
            ((board[0, 0] == symbol && board[2, 2] == symbol) ||
            (board[0, 2] == symbol && board[2, 0] == symbol))
        )
        {
            return true;
        }

        return false;
       }
    }
}