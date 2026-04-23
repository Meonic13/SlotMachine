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
            SuspendLayout();
            // 
            // lblSlot1
            // 
            lblSlot1.BackColor = Color.White;
            lblSlot1.BorderStyle = BorderStyle.FixedSingle;
            lblSlot1.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblSlot1.Location = new Point(447, 145);
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
            lblSlot2.Location = new Point(843, 145);
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
            lblSlot3.Location = new Point(1215, 145);
            lblSlot3.Name = "lblSlot3";
            lblSlot3.Size = new Size(217, 174);
            lblSlot3.TabIndex = 2;
            lblSlot3.Text = "🍒";
            lblSlot3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(2206, 910);
            Controls.Add(lblSlot3);
            Controls.Add(lblSlot2);
            Controls.Add(lblSlot1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Однорукий бандит";
            ResumeLayout(false);
        }

        #endregion

        private Label lblSlot1;
        private Label lblSlot2;
        private Label lblSlot3;
    }
}
