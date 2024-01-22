namespace ATMApp
{
    partial class WithdrawForm
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
            txtAmount = new TextBox();
            label1 = new Label();
            lblError = new Label();
            btnCancel = new Button();
            btnAccept = new Button();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAmount.Location = new Point(29, 56);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(540, 30);
            txtAmount.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 1;
            label1.Text = "Input amout";
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblError.AutoSize = true;
            lblError.ForeColor = Color.DarkRed;
            lblError.Location = new Point(29, 99);
            lblError.Name = "lblError";
            lblError.Size = new Size(47, 23);
            lblError.TabIndex = 2;
            lblError.Text = "error";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(320, 125);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 32);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(444, 125);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(105, 32);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // WithdrawForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(602, 191);
            ControlBox = false;
            Controls.Add(btnAccept);
            Controls.Add(btnCancel);
            Controls.Add(lblError);
            Controls.Add(label1);
            Controls.Add(txtAmount);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "WithdrawForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Withdraw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmount;
        private Label label1;
        private Label lblError;
        private Button btnCancel;
        private Button btnAccept;
    }
}