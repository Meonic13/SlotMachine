namespace SlotMachine
{
    public class Player
    {
        public int Balance { get; private set; }
        public int Bet { get; set; }

        public Player(int StartBalance)
        {
            Balance = StartBalance;
            Bet = 10;
        }

        public bool PlaceBet()
        {
            if (Bet > Balance)
                return false;

            Balance -= Bet;
            return true;
        }

        public void AddWin(int amount)
        {
            Balance += amount;
        }

        public bool IsBroke()
        {
            return Balance <= 0;
        }
    }
}