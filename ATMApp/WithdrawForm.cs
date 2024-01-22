using ATMApp.Lib;

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
            if (string.IsNullOrWhiteSpace(txtAmount.Text.Trim()))
            {
                lblError.Text = "Amount not be empty!";
                lblError.Show();
                return;
            }

            if (!int.TryParse(txtAmount.Text.Trim(), out var amount))
            {
                lblError.Text = "Amount must be numeric!";
                lblError.Show();
                return;
            }

            var withdrawSuccess = atmService.Withdraw(amount);
            if (!withdrawSuccess)
            {
                if (atmService.GetCurrentBalance() < amount)
                {
                    lblError.Text = $"Your balance is {atmService.GetCurrentBalance()}";
                    lblError.Show();
                }

                if (amount <= 0)
                {
                    lblError.Text = $"Amount cannot small than 0!";
                    lblError.Show();

                }

                return;
            }

            MessageBox.Show("Withdraw Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await atmService.WriteAccountAsync(Constants.BANK_PATH);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
