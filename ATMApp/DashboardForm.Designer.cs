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
            // 
            // btnWithdraw
            // 
            btnWithdraw.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnWithdraw.Location = new Point(53, 203);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(324, 32);
            btnWithdraw.TabIndex = 1;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnShowTransactions
            // 
            btnShowTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnShowTransactions.Location = new Point(53, 290);
            btnShowTransactions.Name = "btnShowTransactions";
            btnShowTransactions.Size = new Size(324, 32);
            btnShowTransactions.TabIndex = 2;
            btnShowTransactions.Text = "Show last 5 transactions";
            btnShowTransactions.UseVisualStyleBackColor = true;
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
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 450);
            Controls.Add(lblUserName);
            Controls.Add(btnShowTransactions);
            Controls.Add(btnWithdraw);
            Controls.Add(btnViewBalance);
            Name = "DashboardForm";
            Text = "Dashboard | ATM version 1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewBalance;
        private Button btnWithdraw;
        private Button btnShowTransactions;
        private Label lblUserName;
    }
}