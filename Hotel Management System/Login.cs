using Hotel_Management_System.Controllers;
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

namespace Hotel_Management_System
{
    public partial class Login : Form
    {

        DatabaseConnection dc = new DatabaseConnection();
        String query;
        public int hotelIdToken;
        public int employeeIdToken;

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
            query = "SELECT LoginId FROM Authentication.Login WHERE Username = @username AND Password = @password";
            SqlConnection connection = dc.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", usernameTextField.Text);
            cmd.Parameters.AddWithValue("@password", passwordTextField.Text);
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
                TokenHotelId();
                Statics.setHotelId(hotelIdToken);
                TokenEployeeId();
                Statics.setEmployeeId(employeeIdToken);
                this.Hide();
                Dashboard db = new Dashboard();
                db.Show();
            }
            connection.Close();
        }

        private void TokenEployeeId()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "SELECT EmployeeId FROM Authentication.Login WHERE username = '" + usernameTextField.Text + "' AND password = '" + passwordTextField.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                employeeIdToken = dr.GetInt32(0);
            }
        }

        private void TokenHotelId()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "SELECT HotelId FROM Hotels.Employees WHERE EmployeeId = (SELECT EmployeeId FROM Authentication.Login WHERE username = '" + usernameTextField.Text + "' AND password = '" + passwordTextField.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                hotelIdToken = dr.GetInt32(0);
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            SuperAdminLogin superAdmin = new SuperAdminLogin();
            superAdmin.Show();
        }
    }
}
