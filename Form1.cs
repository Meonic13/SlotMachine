using System;
using System.Windows.Forms;


namespace SlotMachine
{
    public partial class MainForm : Form
    {
        private SlotMachine game; // Главная логика игры

        public MainForm()
        {
            InitializeComponent();

            // Создаем новую игру при запуске
            game = new SlotMachine(100);

            // Обновляем интерфейс начальными значениями
            lblBalance.Text = game.Player.Balance.ToString();
            lblMessage.Text = "Сделайте ставку и нажмите КРУТИТЬ";
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            int bet = (int)numBet.Value; // Получаем ставку из поля ввода

            // Пытаемся сделать спин
            if (!game.Spin(bet))
            {
                MessageBox.Show("Недостаточно денег для ставки!");
                return;
            }

            // Обновляем символы на экране
            lblSlot1.Text = game.Slot1;
            lblSlot2.Text = game.Slot2;
            lblSlot3.Text = game.Slot3;

            // Обновляем баланс
            lblBalance.Text = game.Player.Balance.ToString();

            // Показываем сообщение о результате 
            lblMessage.Text = game.GetResultMessage();

            // Проверяем не закончились ли деньги
            if (!game.Player.IsBroke())
            {
                MessageBox.Show("Игра окончена! У вас закончились деньги");
                btnSpin.Enabled = false; // Блокируем кнопку
            }
        }
    }
}
