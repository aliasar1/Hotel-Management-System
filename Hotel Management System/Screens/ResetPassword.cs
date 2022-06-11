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
    public partial class ResetPassword : Form
    {

        String query;
        DatabaseConnection dc = new DatabaseConnection();

        public ResetPassword()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            changeBtn.Enabled = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = "SELECT LoginId FROM Authentication.Login WHERE Username = '" + Statics.tempUname + "' AND SecurityQuestion = '" + secQCMBox.Text + "' AND Answer = '" + answerField.Text + "'";
            SqlConnection connection = dc.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (!reader.HasRows)
            {
                MessageBox.Show("FAILED! Incorrect information.", "Incorrect Info", MessageBoxButtons.OK);
            }
            else
            {
                verifyBtn.Enabled = false;
                changeBtn.Enabled = true;
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if(newPassField.Text == confirmPassField.Text)
            {
                query = "UPDATE Authentication.Login SET Password = '" + confirmPassField.Text + "' WHERE UserName = '" + Statics.tempUname + "'";
                dc.setData(query, "Password changed successfully.");
                this.Hide();
                Login l = new Login();
                l.Show();
            }
            else
            {
                MessageBox.Show("Password doesn't match.", "Incorrect Info", MessageBoxButtons.OK);
            }
        }

        private void guna2ImageRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
