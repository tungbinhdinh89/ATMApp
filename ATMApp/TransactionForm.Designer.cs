namespace ATMApp
{
    partial class TransactionForm
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
            lvTransactions = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lvTransactions
            // 
            lvTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvTransactions.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvTransactions.GridLines = true;
            lvTransactions.Location = new Point(12, 12);
            lvTransactions.Name = "lvTransactions";
            lvTransactions.Size = new Size(776, 376);
            lvTransactions.TabIndex = 0;
            lvTransactions.UseCompatibleStateImageBehavior = false;
            lvTransactions.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Transaction Date";
            columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Amount";
            columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Type";
            columnHeader3.Width = 150;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(683, 407);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(105, 32);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 451);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(lvTransactions);
            Name = "TransactionForm";
            Text = "TransactionForm";
            Load += TransactionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lvTransactions;
        private Button btnClose;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}