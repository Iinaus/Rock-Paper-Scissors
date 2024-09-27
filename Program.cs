class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();

        while (game.Winner == null) {
            game.SetHands();
            game.CheckRoundWinner();
            game.ShowScoreboard();
            game. CheckGameWinner();
        }

    }
}