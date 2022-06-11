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
    public partial class HotelIntroScreen : Form
    {

        String query;
        DatabaseConnection dc = new DatabaseConnection();

        public HotelIntroScreen()
        {
            InitializeComponent();
        }

        private void HotelIntroScreen_Load(object sender, EventArgs e)
        {
            getDetails();
        }

        private void getDetails()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "Select * FROM Hotels.Hotel WHERE HotelId = " + Statics.hotelIdTKN;
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                hotelName.Text = dr.GetString(1);
                contactLabel.Text = dr.GetString(2);
                emailLabel.Text = dr.GetString(3);
                webLabel.Text = dr.GetString(4);
                descripLabel.Text = dr.GetString(5);
                String address = dr.GetString(8) + ", " + dr.GetString(9) + ", " + dr.GetString(10) + ", " + dr.GetString(12);
                streetLabel.Text = address;
            }
            con.Close();
        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void cityLabel_Click(object sender, EventArgs e)
        {

        }

        private void hotelName_Click(object sender, EventArgs e)
        {

        }
    }
}
