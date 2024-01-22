namespace ATMApp
{
    partial class DashboardForm
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
            btnViewBalance = new Button();
            btnWithdraw = new Button();
            btnShowTransactions = new Button();
            lblUserName = new Label();
            btnDeposit = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnViewBalance
            // 
            btnViewBalance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnViewBalance.Location = new Point(53, 118);
            btnViewBalance.Name = "btnViewBalance";
            btnViewBalance.Size = new Size(324, 32);
            btnViewBalance.TabIndex = 0;
            btnViewBalance.Text = "View Balance";
            btnViewBalance.UseVisualStyleBackColor = true;
            btnViewBalance.Click += btnViewBalance_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnWithdraw.Location = new Point(53, 187);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(324, 32);
            btnWithdraw.TabIndex = 1;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnShowTransactions
            // 
            btnShowTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnShowTransactions.Location = new Point(53, 321);
            btnShowTransactions.Name = "btnShowTransactions";
            btnShowTransactions.Size = new Size(324, 32);
            btnShowTransactions.TabIndex = 2;
            btnShowTransactions.Text = "Show last 5 transactions";
            btnShowTransactions.UseVisualStyleBackColor = true;
            btnShowTransactions.Click += btnShowTransactions_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(22, 21);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(31, 23);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "Hi!";
            // 
            // btnDeposit
            // 
            btnDeposit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDeposit.Location = new Point(53, 254);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(324, 32);
            btnDeposit.TabIndex = 4;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(391, 406);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 32);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 450);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(btnDeposit);
            Controls.Add(lblUserName);
            Controls.Add(btnShowTransactions);
            Controls.Add(btnWithdraw);
            Controls.Add(btnViewBalance);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard | ATM version 1.0";
            Load += DashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewBalance;
        private Button btnWithdraw;
        private Button btnShowTransactions;
        private Label lblUserName;
        private Button btnDeposit;
        private Button btnClose;
    }
}