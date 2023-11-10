using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// This class can be responsible for running the game loop and interacting with the user.
    /// This adheres to the Single Responsibility Principle (SRP).
    /// </summary>
    public class GameRunner
    {
        private readonly ITicTacToeGame ticTacToeGame;

        public GameRunner(ITicTacToeGame ticTacToeGame)
        {
            this.ticTacToeGame = ticTacToeGame;
        }

        public void RunGame()
        {
            ticTacToeGame.PlayGame();
        }
    }
}
