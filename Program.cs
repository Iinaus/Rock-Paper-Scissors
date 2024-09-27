class Program
{
    static void Main(string[] args)
    {
        try {
            Game game = new Game();

            while (game.Winner == null) {
                game.Play();
            }         
            
        } catch (System.Exception e) {
            Console.WriteLine($"Virheen tyyppi: {e.GetType()}");
            Console.WriteLine($"Virheen viesti: {e.Message}");
        }

    }
}