class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        Computer cp = new Computer();

        int PlayerHand = player.ChooseHand();
        int CpHand = cp.RandomHand(); 

        Console.WriteLine($"Player {player.Name} chose {PlayerHand}");  
        Console.WriteLine($"Computer chose {CpHand}"); 

    }
}