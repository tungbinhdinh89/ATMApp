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
    public partial class DepositForm : Form
    {
        private readonly ATMService atmService;

        public DepositForm(ATMService atmService)
        {
            this.atmService = atmService;
            InitializeComponent();
            lblError.Hide();
        }

        private async void btnAccept_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAmount.Text.Trim()))
            {
                lblError.Text = "Amount not be empty!";
                lblError.Show();
                return;
            }

            if (!int.TryParse(txtAmount.Text.Trim(), out var amount))
            {
                lblError.Text = "Amount must be numeric!";
                return;
            }

            var depositSuccess =  atmService.Deposit(amount);

            if (!depositSuccess)
            {
                if (amount <= 0)
                {
                    lblError.Text = $"Amount cannot small than 0";
                }
                return;
            }

            await atmService.WriteAccountAsync(Constants.BANK_PATH);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
