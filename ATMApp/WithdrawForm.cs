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
    public partial class WithdrawForm : Form
    {
        private readonly ATMService atmService;

        public WithdrawForm(ATMService atmService)
        {
            this.atmService = atmService;
            InitializeComponent();
            lblError.Hide();
        }

        private async void btnAccept_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAmount.Text.Trim(), out var amount))
            {
                return;
            }

            var withdrawSuccess = atmService.Withdraw(amount);
            if (!withdrawSuccess)
            {
                if (atmService.GetCurrentBalance() < amount)
                {
                    //MessageBox.Show("Your balance is small than amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblError.Text = $"Your balance is {atmService.GetCurrentBalance()}";
                    lblError.Show();
                }

                if (amount < 0)
                {
                    lblError.Text = $"Amount cannot small than 0";
                    lblError.Show();
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
