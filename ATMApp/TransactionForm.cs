using ATMApp.Lib;
using ATMApp.Lib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ATMApp
{
    public partial class TransactionForm : Form
    {
        private readonly ATMService atmService;
        public TransactionForm(ATMService atmService)
        {
            this.atmService = atmService;
            InitializeComponent();
            LoadDataToListView(atmService.GetCurrentTransaction());
        }

        public void LoadDataToListView(List<AccountTransaction> transactions)
        {
            lvTransactions.Items.Clear();

            foreach (AccountTransaction transaction in transactions)
            {
                if (transaction is null)
                {
                    throw new ArgumentNullException("Not null");
                }
                ListViewItem item = new ListViewItem(transaction.TransactionDate.ToString());
                item.SubItems.Add(transaction.Amount.ToString());
                item.SubItems.Add(transaction.Type);

                item.Tag = transaction;
                lvTransactions.Items.Add(item);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
