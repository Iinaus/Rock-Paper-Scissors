class Player 
{
    public string Name { get; private set; }
    public int Wins { get; private set; }
    public int Choice { get; set; }

    public Player() {
        Name = null;
        Wins = 0;
    }

    public void SetName() {
        Console.WriteLine("Set name for player:");
        Name = Console.ReadLine(); 
    }

    public int ChooseHand() {
        
        Console.WriteLine("Choose 1) Rock 2) Paper 3) Scissors:");
        string ChoiceStr = Console.ReadLine();

        Choice = int.Parse(ChoiceStr);

        if (ChoiceStr == "1") {
            Console.WriteLine("You chose 1) rock.");
        } else if (ChoiceStr == "2") {
            Console.WriteLine("You chose 2) paper.");
        } else if (ChoiceStr == "3") {
            Console.WriteLine("You chose 3) scissors.");
        } else {
            Console.WriteLine("Invalid choice. Please choose 1, 2, or 3.");
        }
            
        return Choice;
    }

    public void AddWin() {
        Wins++;
    }
}