namespace SlotMachine
{
    public class WinChecker
    {
        public int Check(string slot1, string slot2, string slot3, int bet)
        {
            if (slot1 == slot2 && slot2 == slot3)
            {
                return bet * 5;
            }

            if (slot1 == slot2 || slot2 == slot3 || slot1 == slot3)
            {
                return bet * 2;
            }

            return 0;
        }

        public string GetMessage(string slot1, string slot2, string slot3)
        {
            if (slot1 == slot2 && slot2 == slot3)
            {
                return "ДЖЕКПОТ! Три одинаковых!";
            }

            if (slot1 == slot2 || slot2 == slot3 || slot1 == slot3)
            {
                return "Есть совпадение! Вы выиграли!";
            }

            return "Не повезло :( Попробуйте ещё";
        }
    }
}