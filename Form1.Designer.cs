namespace SlotMachine
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSlot1 = new Label();
            lblSlot2 = new Label();
            lblSlot3 = new Label();
            btnSpin = new Button();
            lblBalanceTitle = new Label();
            lblBalance = new Label();
            lblBetTitle = new Label();
            numBet = new NumericUpDown();
            lblMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)numBet).BeginInit();
            SuspendLayout();
            // 
            // lblSlot1
            // 
            lblSlot1.BackColor = Color.White;
            lblSlot1.BorderStyle = BorderStyle.FixedSingle;
            lblSlot1.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblSlot1.Location = new Point(502, 96);
            lblSlot1.Name = "lblSlot1";
            lblSlot1.Size = new Size(217, 174);
            lblSlot1.TabIndex = 0;
            lblSlot1.Text = "🍒";
            lblSlot1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSlot2
            // 
            lblSlot2.BackColor = Color.White;
            lblSlot2.BorderStyle = BorderStyle.FixedSingle;
            lblSlot2.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblSlot2.Location = new Point(923, 96);
            lblSlot2.Name = "lblSlot2";
            lblSlot2.Size = new Size(217, 174);
            lblSlot2.TabIndex = 1;
            lblSlot2.Text = "🍒";
            lblSlot2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSlot3
            // 
            lblSlot3.BackColor = Color.White;
            lblSlot3.BorderStyle = BorderStyle.FixedSingle;
            lblSlot3.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblSlot3.Location = new Point(1366, 96);
            lblSlot3.Name = "lblSlot3";
            lblSlot3.Size = new Size(217, 174);
            lblSlot3.TabIndex = 2;
            lblSlot3.Text = "🍒";
            lblSlot3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSpin
            // 
            btnSpin.BackColor = Color.Gold;
            btnSpin.FlatStyle = FlatStyle.Flat;
            btnSpin.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSpin.Location = new Point(863, 424);
            btnSpin.Name = "btnSpin";
            btnSpin.Size = new Size(325, 69);
            btnSpin.TabIndex = 3;
            btnSpin.Text = "🎰 КРУТИТЬ";
            btnSpin.UseVisualStyleBackColor = false;
            btnSpin.Click += btnSpin_Click;
            // 
            // lblBalanceTitle
            // 
            lblBalanceTitle.AutoSize = true;
            lblBalanceTitle.BackColor = Color.Transparent;
            lblBalanceTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblBalanceTitle.ForeColor = Color.White;
            lblBalanceTitle.Location = new Point(54, 638);
            lblBalanceTitle.Name = "lblBalanceTitle";
            lblBalanceTitle.Size = new Size(127, 45);
            lblBalanceTitle.TabIndex = 4;
            lblBalanceTitle.Text = "Баланс:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.BackColor = Color.Transparent;
            lblBalance.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblBalance.ForeColor = Color.Yellow;
            lblBalance.Location = new Point(200, 638);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(84, 50);
            lblBalance.TabIndex = 5;
            lblBalance.Text = "100";
            // 
            // lblBetTitle
            // 
            lblBetTitle.AutoSize = true;
            lblBetTitle.BackColor = Color.Transparent;
            lblBetTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblBetTitle.ForeColor = Color.White;
            lblBetTitle.Location = new Point(54, 720);
            lblBetTitle.Name = "lblBetTitle";
            lblBetTitle.Size = new Size(125, 45);
            lblBetTitle.TabIndex = 6;
            lblBetTitle.Text = "Ставка:";
            // 
            // numBet
            // 
            numBet.BackColor = Color.DarkGreen;
            numBet.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numBet.ForeColor = Color.Gold;
            numBet.Location = new Point(200, 720);
            numBet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numBet.Name = "numBet";
            numBet.Size = new Size(240, 50);
            numBet.TabIndex = 7;
            numBet.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblMessage.ForeColor = Color.White;
            lblMessage.Location = new Point(68, 823);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(300, 47);
            lblMessage.TabIndex = 8;
            lblMessage.Text = "пусто";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(2206, 910);
            Controls.Add(lblMessage);
            Controls.Add(numBet);
            Controls.Add(lblBetTitle);
            Controls.Add(lblBalance);
            Controls.Add(lblBalanceTitle);
            Controls.Add(btnSpin);
            Controls.Add(lblSlot3);
            Controls.Add(lblSlot2);
            Controls.Add(lblSlot1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Однорукий бандит";
            ((System.ComponentModel.ISupportInitialize)numBet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSlot1;
        private Label lblSlot2;
        private Label lblSlot3;
        private Button btnSpin;
        private Label lblBalanceTitle;
        private Label lblBalance;
        private Label lblBetTitle;
        private NumericUpDown numBet;
        private Label lblMessage;
    }
}
