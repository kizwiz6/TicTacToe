using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        private char[,] board;
        private PlayerSymbol currentPlayer;

        public TicTacToeGame()
        {
            board = new char[3, 3];
        }

        public string GetResult()
        {
            if (WinsTicTacToe(PlayerSymbol.X))
            {
                return "X wins";
            }
            else if (WinsTicTacToe(PlayerSymbol.O))
            {
                return "O wins";
            }
            else if (IsBoardFull())
            {
                return "Tie";
            }
            else
            {
                return "Game in progress";
            }
        }

        public void PlayGame()
        {
            do
            {
                ResetBoard();
                TakeUserInput();
                DisplayBoard();
            } while (!HasWinner() && !IsBoardFull());

            Console.WriteLine(GetResult());
        }

        public void ResetBoard()
        {
            // Initialize the board with empty spaces
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
        }

        public void TakeUserInput()
        {
            bool validInput = false;
            int row = -1, col = -1; // Initialise with invalid values

            do
            {
                Console.Write($"Player {currentPlayer}'s turn. Enter row (0, 1, or 2) and column (0, 1, or 2) separated by a space: ");
                string input = Console.ReadLine();

                string[] coordinates = input.Split(' ');

                if (coordinates.Length == 2 && int.TryParse(coordinates[0], out row) && int.TryParse(coordinates[1], out col))
                {
                    if (row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ')
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter valid and unoccupied coordinates.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input format. Please enter row and column as two space-separated numbers.");
                }
            } while (!validInput);


            // Update the board with the player's symbol
            SetSymbol(GetPlayerSymbol(currentPlayer), row, col);

            // Switch to the other player for the next turn
            currentPlayer = (currentPlayer == PlayerSymbol.X) ? PlayerSymbol.O : PlayerSymbol.X;

        }

        public char GetPlayerSymbol(PlayerSymbol player)
        {
            return (player == PlayerSymbol.X) ? 'X' : 'O';
        }

        public void DisplayBoard()
        {
            // Improved visualization of the game board
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{board[i, 0]} | {board[i, 1]} | {board[i, 2]}");
                if (i < 2)
                {
                    Console.WriteLine("---------");
                }
            }
        }

        public bool WinsTicTacToe(PlayerSymbol symbol)
        {
            // Check rows and columns
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == GetPlayerSymbol(symbol) && board[i, 1] == GetPlayerSymbol(symbol) && board[i, 2] == GetPlayerSymbol(symbol)) ||
                    (board[0, i] == GetPlayerSymbol(symbol) && board[1, i] == GetPlayerSymbol(symbol) && board[2, i] == GetPlayerSymbol(symbol)))
                {
                    return true;
                }
            }

            // Check diagonals
            if (board[1, 1] == GetPlayerSymbol(symbol) &&
                ((board[0, 0] == GetPlayerSymbol(symbol) && board[2, 2] == GetPlayerSymbol(symbol)) ||
                (board[0, 2] == GetPlayerSymbol(symbol) && board[2, 0] == GetPlayerSymbol(symbol))))
            {
                return true;
            }

            // If no winner, check if the board is full
            bool boardFull = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        boardFull = false;
                        break;
                    }
                }
            }

            // Return true only if there is no winner and the board is full
            return boardFull && !HasWinner();

        }

        public void SetSymbol(char symbol, int row, int col)
        {
            board[row, col] = symbol;
        }

        public bool HasWinner()
        {
            // Check rows and columns
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == 'X' && board[i, 1] == 'X' && board[i, 2] == 'X') ||
                    (board[0, i] == 'X' && board[1, i] == 'X' && board[2, i] == 'X') ||
                    (board[i, 0] == 'O' && board[i, 1] == 'O' && board[i, 2] == 'O') ||
                    (board[0, i] == 'O' && board[1, i] == 'O' && board[2, i] == 'O'))
                {
                    return true;
                }
            }

            // Check diagonals
            if ((board[1, 1] == 'X' && ((board[0, 0] == 'X' && board[2, 2] == 'X') || (board[0, 2] == 'X' && board[2, 0] == 'X'))) ||
                (board[1, 1] == 'O' && ((board[0, 0] == 'O' && board[2, 2] == 'O') || (board[0, 2] == 'O' && board[2, 0] == 'O'))))
            {
                return true;
            }

            return false; // No winner
        }

        public bool IsBoardFull()
        {
            // Check if the board is full
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool PlayAgain()
        {
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            return response.ToLower() == "yes";

        }
    }
}
