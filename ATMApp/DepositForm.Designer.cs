namespace ATMApp
{
    partial class DepositForm
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
            btnAccept = new Button();
            btnCancel = new Button();
            lblError = new Label();
            label1 = new Label();
            txtAmount = new TextBox();
            SuspendLayout();
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(444, 124);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(105, 32);
            btnAccept.TabIndex = 9;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(320, 124);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 32);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblError.AutoSize = true;
            lblError.ForeColor = Color.DarkRed;
            lblError.Location = new Point(29, 98);
            lblError.Name = "lblError";
            lblError.Size = new Size(47, 23);
            lblError.TabIndex = 7;
            lblError.Text = "error";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 6;
            label1.Text = "Input amout";
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAmount.Location = new Point(29, 55);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(290, 30);
            txtAmount.TabIndex = 5;
            // 
            // DepositForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 173);
            Controls.Add(btnAccept);
            Controls.Add(btnCancel);
            Controls.Add(lblError);
            Controls.Add(label1);
            Controls.Add(txtAmount);
            Name = "DepositForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Deposit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAccept;
        private Button btnCancel;
        private Label lblError;
        private Label label1;
        private TextBox txtAmount;
    }
}