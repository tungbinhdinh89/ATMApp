namespace ATMApp
{
    partial class LoginForm
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
            txtCardNumber = new TextBox();
            txtPin = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtCardNumber
            // 
            txtCardNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCardNumber.Location = new Point(46, 142);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(355, 30);
            txtCardNumber.TabIndex = 0;
            // 
            // txtPin
            // 
            txtPin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPin.Location = new Point(46, 203);
            txtPin.Name = "txtPin";
            txtPin.PasswordChar = '*';
            txtPin.Size = new Size(355, 30);
            txtPin.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Location = new Point(186, 272);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(93, 32);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 453);
            Controls.Add(btnLogin);
            Controls.Add(txtPin);
            Controls.Add(txtCardNumber);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login  | ATM version 1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCardNumber;
        private TextBox txtPin;
        private Button btnLogin;
    }
}