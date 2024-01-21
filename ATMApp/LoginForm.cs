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
    public partial class LoginForm : Form
    {
        private ATMService atmService = new ATMService();

        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Enabled = false;
            lblError.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var cardNumber = txtCardNumber.Text?.Trim();
            var pin = txtPin.Text?.Trim();  

            if (string.IsNullOrWhiteSpace(cardNumber) || string.IsNullOrWhiteSpace(pin))
            {
                return;
            }

            if(!int.TryParse(pin, out var pinNumber)) 
            {
                return;
            }

            var valid = atmService.Login(cardNumber, pinNumber);
            if (!valid)
            {
                this.lblError.Text = "Card number or pin is invalid!";
                lblError.Show();
                return;
            }

            Hide();
            new DashboardForm(atmService).ShowDialog();
        }

        private async void  LoginForm_Load(object sender, EventArgs e)
        {
           await atmService.LoadAccountsAsync(Constants.BANK_PATH);
          
            btnLogin.Enabled = true;
        }
    }
}
