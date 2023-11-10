namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of FunWelcomeMessageGenerator
            IWelcomeMessageGenerator welcomeMessageGenerator = new FunWelcomeMessageGenerator();

            // Create an instance of WelcomeMessageDisplayer with the welcomeMessageGenerator
            WelcomeMessageDisplayer welcomeMessageDisplayer = new WelcomeMessageDisplayer(welcomeMessageGenerator);

            // Display the welcome message
            welcomeMessageDisplayer.DisplayWelcomeMessage();

            // Create an instance of TicTacToeGame
            ITicTacToeGame ticTacToeGame = new TicTacToeGame();

            // Create a GameRunner with the TicTacToeGame instance
            GameRunner gameRunner = new GameRunner(ticTacToeGame);

            // Run the game
            gameRunner.RunGame();
        }
    }
}