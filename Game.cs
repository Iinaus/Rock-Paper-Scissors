class Game 
{
    public String Winner { get; set; }
    private int Round { get; set; }
    private int PlayerHand { get; set; }
    private int CpHand { get; set; }

    Player player = new Player();
    Computer cp = new Computer();

    public Game() {
        Winner = null;
        Round = 1;
    }

    public void Play() {
        if (player.Name == null) {
            player.SetName();
        }
        SetHands();
        CheckRoundWinner();
        ShowScoreboard();
        CheckGameWinner();
    }

    private void SetHands() {
        PlayerHand = player.ChooseHand();
        CpHand = cp.RandomHand(); 

        string playerHandText = NumberToSign(PlayerHand);
        string cpHandText = NumberToSign(CpHand);

        Console.WriteLine($"Player {player.Name} chose {playerHandText}");  
        Console.WriteLine($"Computer chose {cpHandText}");      
    }

    private string NumberToSign(int num) {
        if (num == 1) {
            return "rock";
        } else if (num == 2) {
            return "paper";
        } else if (num == 3) {
            return "scissors";
        } else {
            return "Invalid input";
        }

    }

    private void CheckRoundWinner() {
        if (PlayerHand == 1 && CpHand == 3 ||
            PlayerHand == 2 && CpHand == 1 ||
            PlayerHand == 3 && CpHand == 2) {
                Console.WriteLine($"Player {player.Name} wins this round");
                player.AddWin();
        } else if (PlayerHand == CpHand) {
            Console.WriteLine("Draw");
        } else {
            Console.WriteLine("Computer wins this round");
            cp.AddWin();
        }
    }

    private void CheckGameWinner() {
        if (player.Wins == 3) {
            Winner = "Player";
            Console.WriteLine($"----- Player {player.Name} wins the game -----");
        } else if (cp.Wins == 3) {
            Winner = "Computer";
            Console.WriteLine("----- Computer wins the game -----");
        } else {
            Round++;
        }       
    }   

    private void ShowScoreboard() {
        Console.WriteLine("----- SCOREBOARD -----"); 
        Console.WriteLine($"Round: {Round}"); 
        Console.WriteLine($"Player {player.Name} score: {player.Wins}"); 
        Console.WriteLine($"Computer score: {cp.Wins}");  
        Console.WriteLine("----------------------");           
    } 
}