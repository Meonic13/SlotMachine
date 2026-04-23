namespace SlotMachine
{
    public class Symbols
    {
        private string[] symbollist = { "🍒", "🍋", "🍊", "🔔", "7" };

        public string[] GetSymbols()
        {
            return symbollist;
        }

        public int Count()
        {
            return symbollist.Length;
        }
    }
}