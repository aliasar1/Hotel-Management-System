using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();
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
                Dashboard db = new Dashboard();
                this.Hide();
                db.Show();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            //SuperAdminScreen superAdmin = new SuperAdminScreen();
            
        }
    }
}
