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
    public partial class SuperAdminLogin : Form
    {
        public SuperAdminLogin()
        {
            InitializeComponent();
        }

        private void SuperAdminScreen_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(usernameTextField.Text) || String.IsNullOrEmpty(passwordTextField.Text))
            {
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
                this.Hide();
                HotelChainPage hotelChain = new HotelChainPage();
                hotelChain.Show();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
