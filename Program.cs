namespace TicTacToe
{
    public enum PlayerSymbol
    {
        X,
        O
    }
    public class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame game = new TicTacToeGame();
            game.PlayGame();
        }
    }
}