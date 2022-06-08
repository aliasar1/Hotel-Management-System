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
    public partial class ShowDefaultScreen : Form
    {

        private static Random random = new Random();
        String query;
        DatabaseConnection dc = new DatabaseConnection();
        String uname;
        String password;
        bool isEmployee = false;
        public ShowDefaultScreen()
        {
            InitializeComponent();
        }

        public ShowDefaultScreen(bool isEmployee)
        {
            InitializeComponent();
            this.isEmployee = isEmployee;
        }

        public static string randomPassoword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (isEmployee)
            {
                query = "INSERT INTO Authentication.Login (Username, Password, HotelId, EmployeeId) VALUES ('" + uname + "', '" + password + "', " + Statics.hotelIdTKN + ", " + Statics.tempEmpId + ")";
            }
            else
            {
                query = "INSERT INTO Authentication.Login (Username, Password, HotelId) VALUES ('" + uname + "', '" + password + "', " + Statics.hotelIdTKN + ")";
            }
            SqlConnection connection = dc.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
            this.Hide();
        }

        private void ShowDefaultScreen_Load(object sender, EventArgs e)
        {
            if (isEmployee)
            {
                uname = Statics.employeeNameAndId;
                uname = uname.Replace(" ", String.Empty);
                password = randomPassoword();
                usernameTextField.Text = uname;
                passwordTextField.Text = password;
            }
            else
            {
                uname = Statics.hotelNameAndId;
                uname = uname.Replace(" ", String.Empty);
                password = randomPassoword();
                usernameTextField.Text = uname;
                passwordTextField.Text = password;
            }
        }
    }
}
