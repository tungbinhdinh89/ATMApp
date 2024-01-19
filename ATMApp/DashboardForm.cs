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
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnViewBalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your balance is 5000$", "Balance", MessageBoxButtons.OK);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

        }

        private void btnShowTransactions_Click(object sender, EventArgs e)
        {

        }
    }
}
