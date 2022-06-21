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

namespace Hotel_Management_System.Screens
{
    public partial class CreatePassword : Form
    {

        String query;
        DatabaseConnection dc = new DatabaseConnection();
        int employeeIdToken;
        public CreatePassword()
        {
            InitializeComponent();
        }

        private void PasswordResetScreen_Load(object sender, EventArgs e)
        {
            usernameTextField.Text = Statics.uname;
            passwordTextField.Text = Statics.pass;
        }

        private bool checkUserType()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "SELECT EmployeeId from Authentication.Login WHERE Username = '" + Statics.uname + "' AND Password = '" + Statics.pass +"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.GetValue(0) != DBNull.Value)
                {
                    employeeIdToken = dr.GetInt32(0);
                }
            }
            if (employeeIdToken > 0)
                return true;
            else
                return false;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            bool check = checkUserType();
            if (newPassField.Text.Length < 8 || confirmPassField.Text.Length < 8)
            {
                MessageBox.Show("Minimum password length must be 8.", "Incorrect Info", MessageBoxButtons.OK);
                return;
            }
            if (newPassField.Text == confirmPassField.Text && secQCMBox.SelectedIndex != -1 && answerField.Text != "")
            {
                if(check == true)
                {
                    query = "UPDATE Authentication.Login SET Username = '" + usernameTextField.Text + "', Password = '" + newPassField.Text + "', EmployeeId = " + Statics.employeeIdTKN + ", SecurityQuestion = '" + secQCMBox.Text + "', Answer = '" + answerField.Text + "', NewUser = 'NO', HotelId = " + Statics.hotelIdTKN + " WHERE Username = '" + usernameTextField.Text + "'";
                    dc.setData(query, "Password updated successfully.");
                }
                else
                {
                    Console.WriteLine(Statics.hotelIdTKN);
                    query = "UPDATE Authentication.Login SET Username = '" + usernameTextField.Text + "', Password = '" + newPassField.Text + "', EmployeeId = " + "NULL" + ", SecurityQuestion = '" + secQCMBox.Text + "', Answer = '" + answerField.Text + "', NewUser = 'NO', HotelId = " + Statics.hotelIdTKN + " WHERE Username = '" + usernameTextField.Text + "'";
                    dc.setData(query, "Password updated successfully.");
                }
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Please provide correct information.", "Missing Info", MessageBoxButtons.OK);
            }
        }

        private void newPassField_IconRightClick(object sender, EventArgs e)
        {
            Image myimage1 = new Bitmap(@"C:\Users\Ali Asar\source\repos\Hotel Management System\Hotel Management System\Icons\eyevisoff.png");
            Image myimage2 = new Bitmap(@"C:\Users\Ali Asar\source\repos\Hotel Management System\Hotel Management System\Icons\eyevisible.png");

            if (newPassField.UseSystemPasswordChar == true)
            {
                newPassField.UseSystemPasswordChar = false;
                newPassField.IconRight = myimage2;
            }
            else if (newPassField.UseSystemPasswordChar == false)
            {
                newPassField.UseSystemPasswordChar = true;
                newPassField.IconRight = myimage1;
            }
        }

        private void confirmPassField_IconRightClick(object sender, EventArgs e)
        {
            Image myimage1 = new Bitmap(@"C:\Users\Ali Asar\source\repos\Hotel Management System\Hotel Management System\Icons\eyevisoff.png");
            Image myimage2 = new Bitmap(@"C:\Users\Ali Asar\source\repos\Hotel Management System\Hotel Management System\Icons\eyevisible.png");

            if (confirmPassField.UseSystemPasswordChar == true)
            {
                confirmPassField.UseSystemPasswordChar = false;
                confirmPassField.IconRight = myimage2;
            }
            else if (confirmPassField.UseSystemPasswordChar == false)
            {
                confirmPassField.UseSystemPasswordChar = true;
                confirmPassField.IconRight = myimage1;
            }
        }
    }
}
