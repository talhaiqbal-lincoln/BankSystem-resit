namespace BankSystem
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            checkBalance = new Button();
            withdraw = new Button();
            deposit = new Button();
            ShowTransactions = new Button();
            transfer = new Button();
            label1 = new Label();
            label3 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            button1 = new Button();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            ChangePassword = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(586, 603);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // checkBalance
            // 
            checkBalance.BackColor = Color.FromArgb(70, 70, 70);
            checkBalance.Cursor = Cursors.Hand;
            checkBalance.FlatStyle = FlatStyle.Popup;
            checkBalance.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            checkBalance.ForeColor = Color.White;
            checkBalance.Location = new Point(409, 110);
            checkBalance.Name = "checkBalance";
            checkBalance.Size = new Size(308, 50);
            checkBalance.TabIndex = 4;
            checkBalance.Text = "Check Balance";
            checkBalance.UseVisualStyleBackColor = false;
            checkBalance.Click += checkBalance_Click;
            // 
            // withdraw
            // 
            withdraw.BackColor = Color.FromArgb(70, 70, 70);
            withdraw.Cursor = Cursors.Hand;
            withdraw.FlatStyle = FlatStyle.Popup;
            withdraw.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            withdraw.ForeColor = Color.White;
            withdraw.Location = new Point(409, 195);
            withdraw.Name = "withdraw";
            withdraw.Size = new Size(308, 47);
            withdraw.TabIndex = 5;
            withdraw.Text = "Withdraw";
            withdraw.UseVisualStyleBackColor = false;
            withdraw.Click += withdraw_Click;
            // 
            // deposit
            // 
            deposit.BackColor = Color.FromArgb(70, 70, 70);
            deposit.Cursor = Cursors.Hand;
            deposit.FlatStyle = FlatStyle.Popup;
            deposit.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            deposit.ForeColor = Color.White;
            deposit.Location = new Point(409, 279);
            deposit.Name = "deposit";
            deposit.Size = new Size(308, 47);
            deposit.TabIndex = 6;
            deposit.Text = "Deposit";
            deposit.UseVisualStyleBackColor = false;
            deposit.Click += deposite_Click;
            // 
            // ShowTransactions
            // 
            ShowTransactions.BackColor = Color.FromArgb(70, 70, 70);
            ShowTransactions.Cursor = Cursors.Hand;
            ShowTransactions.FlatStyle = FlatStyle.Popup;
            ShowTransactions.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ShowTransactions.ForeColor = Color.White;
            ShowTransactions.Location = new Point(409, 424);
            ShowTransactions.Name = "ShowTransactions";
            ShowTransactions.Size = new Size(308, 47);
            ShowTransactions.TabIndex = 7;
            ShowTransactions.Text = "Show Transactions";
            ShowTransactions.UseVisualStyleBackColor = false;
            ShowTransactions.Click += ShowTransactions_Click;
            // 
            // transfer
            // 
            transfer.BackColor = Color.FromArgb(70, 70, 70);
            transfer.Cursor = Cursors.Hand;
            transfer.FlatStyle = FlatStyle.Popup;
            transfer.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            transfer.ForeColor = Color.White;
            transfer.Location = new Point(409, 347);
            transfer.Name = "transfer";
            transfer.Size = new Size(308, 47);
            transfer.TabIndex = 9;
            transfer.Text = "Transfer";
            transfer.UseVisualStyleBackColor = false;
            transfer.Click += transfer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(68, 16);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 2;
            label1.Text = "Hello";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(343, 16);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // iconButton1
            // 
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.MediumSeaGreen;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton1.IconColor = SystemColors.Control;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(8, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(52, 60);
            iconButton1.TabIndex = 5;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.LightSeaGreen;
            button1.Location = new Point(68, 582);
            button1.Name = "button1";
            button1.Size = new Size(120, 49);
            button1.TabIndex = 10;
            button1.Text = "Sign out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // iconButton2
            // 
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            iconButton2.ForeColor = Color.MediumSeaGreen;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconButton2.IconColor = SystemColors.Control;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(15, 587);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(77, 39);
            iconButton2.TabIndex = 11;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // ChangePassword
            // 
            ChangePassword.BackColor = Color.FromArgb(70, 70, 70);
            ChangePassword.Cursor = Cursors.Hand;
            ChangePassword.FlatStyle = FlatStyle.Popup;
            ChangePassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ChangePassword.ForeColor = Color.White;
            ChangePassword.Location = new Point(409, 498);
            ChangePassword.Name = "ChangePassword";
            ChangePassword.Size = new Size(308, 47);
            ChangePassword.TabIndex = 12;
            ChangePassword.Text = "Change Password";
            ChangePassword.UseVisualStyleBackColor = false;
            ChangePassword.Click += ChangePassword_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 652);
            panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 284);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(788, 6);
            label6.Name = "label6";
            label6.Size = new Size(35, 38);
            label6.TabIndex = 15;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(835, 652);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(ChangePassword);
            Controls.Add(label3);
            Controls.Add(transfer);
            Controls.Add(ShowTransactions);
            Controls.Add(label2);
            Controls.Add(deposit);
            Controls.Add(withdraw);
            Controls.Add(checkBalance);
            ForeColor = Color.DarkSalmon;
            FormBorderStyle = FormBorderStyle.None;
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += User_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Button checkBalance;
        private Button withdraw;
        private Button deposit;
        private Button ShowTransactions;
        private Button transfer;
        private Label label1;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Button button1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Button ChangePassword;
        private System.Windows.Forms.Timer timer2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
    }
}