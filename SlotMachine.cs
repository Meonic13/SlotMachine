using System;

namespace SlotMachine
{
    public class SlotMachine
    {
        private Random random = new Random();
        private Symbols symbols = new Symbols();
        private WinChecker winChecker = new WinChecker();

        public Player Player { get; private set; }

        public string Slot1 { get; private set; }
        public string Slot2 { get; private set; }
        public string Slot3 { get; private set; }

        public SlotMachine(int startBalance)
        {
            Player = new Player(startBalance);
        }
        
        public bool Spin(int bet)
        {
            Player.Bet = bet;

            if (!Player.PlaceBet())
            {
                return false;
            }

            Slot1 = symbols.GetSymbols()[random.Next(symbols.Count())];
            Slot2 = symbols.GetSymbols()[random.Next(symbols.Count())];
            Slot3 = symbols.GetSymbols()[random.Next(symbols.Count())];

            int win = winChecker.Check(Slot1, Slot2, Slot3, bet);
            Player.AddWin(win);

            return true;
        }

        public string GetResultMessage()
        {
            return winChecker.GetMessage(Slot1, Slot2, Slot3);  
        }
    }
}