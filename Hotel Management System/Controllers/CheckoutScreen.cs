using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.Controllers
{
    public partial class CheckoutScreen : Form
    {
        public CheckoutScreen()
        {
            InitializeComponent();
            searchButton.Enabled = false;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            searchButton.Enabled = true;
            payButton.Enabled = false;
            paymentIdField.ReadOnly = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            paymentIdField.ReadOnly = true;
            payButton.Enabled = true;
            searchButton.Enabled = false;
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard ds = new Dashboard();
            ds.Show();
        }
    }
}
