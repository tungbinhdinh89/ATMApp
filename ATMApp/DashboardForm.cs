using ATMApp.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMApp
{
    public partial class DashboardForm : Form
    {
        private readonly ATMService atmService;

        public DashboardForm(ATMService atmService)
        {
            this.atmService = atmService;

            InitializeComponent();
        }

        private void btnViewBalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your balance is {atmService.GetCurrentBalance()}$", "Balance", MessageBoxButtons.OK);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            new WithdrawForm(atmService).ShowDialog();
        }

        private void btnShowTransactions_Click(object sender, EventArgs e)
        {
            new TransactionForm(atmService).ShowDialog();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            if (atmService is null)
            {
                throw new ArgumentException(nameof(atmService));
            }

            this.lblUserName.Text = $"Hi, {atmService.GetCurrentAccountName()}";
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            new DepositForm(atmService).ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
