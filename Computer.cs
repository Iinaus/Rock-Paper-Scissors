class Computer : Player 
{
    public int RandomHand() {
        Random rdm = new Random();
        Choice = rdm.Next(1,4);
        return Choice;
    }
}