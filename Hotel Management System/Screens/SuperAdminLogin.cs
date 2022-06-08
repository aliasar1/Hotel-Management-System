using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.Controllers
{
    public partial class SuperAdminLogin : Form
    {

        DatabaseConnection dc = new DatabaseConnection();
        String query;

        public SuperAdminLogin()
        {
            InitializeComponent();
        }

        private void SuperAdminScreen_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = "SELECT AdminId FROM Authentication.Admin WHERE Username = '" + usernameTextField.Text + "' AND Password = '" + passwordTextField.Text +"'";
            SqlConnection connection = dc.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (String.IsNullOrEmpty(usernameTextField.Text) || String.IsNullOrEmpty(passwordTextField.Text))
            {
                errorLabel.Text = "        All fields are required.";
                errorLabel.Visible = true;
            }
            else if (!reader.HasRows)
            {
                errorLabel.Text = "Incorrect username or password.";
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
                this.Hide();
                AdminHotelsView view = new AdminHotelsView();
                view.Show();
            }
            connection.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
