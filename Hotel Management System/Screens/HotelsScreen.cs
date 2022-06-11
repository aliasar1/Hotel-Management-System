using Hotel_Management_System.Screens;
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
    public partial class HotelsScreen : Form
    {
        String query;
        DatabaseConnection dc = new DatabaseConnection();

        private String name;
        private String contact;
        private String zip;
        private String address;
        private String city;
        private String country;
        private String web;
        private int capacity;
        private int floors;
        private String street;
        private String description;
        private String email;
        public HotelsScreen()
        {
            InitializeComponent();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HotelsScreen_Load(object sender, EventArgs e)
        {
            getHotelDetails();
        }

        private void getFieldsData()
        {
            name = hotelNameField.Text;
            contact = contactField.Text;
            zip = zipField.Text;
            address = addressField.Text;
            city = cityField.Text;
            country = countryField.Text;
            web = webField.Text;
            capacity = int.Parse(capacityField.Text);
            floors = int.Parse(floorCountField.Text);
            street = streetField.Text;
            description = descriptionFIeld.Text;
            email = emailField.Text;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (hotelNameField.Text == "" || contactField.Text == "" || zipField.Text == "" || addressField.Text == "" ||
                 cityField.Text == "" || countryField.Text == "" || webField.Text == "" || emailField.Text == "" || capacityField.Text == "" ||
                 floorCountField.Text == "" || streetField.Text == "" || descriptionFIeld.Text == "" || emailField.Text == "")
            {
                MessageBox.Show("Please fill all fields to update.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                getFieldsData();
                query = "UPDATE Hotels.Hotel SET Name = '" + name + "', ContactNumber = '" + contact + "', Email= '" + email + "', Website = '" + web + "', Description = '" + description + "', FloorCount = " + floors + ", TotalRooms = " +  capacity + ", AddressLine = '" + address + "', Street = '" + street + "', City = '" + city + "' , Country = '" + country + "', Zip = '" + zip + "' WHERE HotelId = " + Statics.hotelIdTKN;
                dc.setData(query, "Record updated successfully.");
                getHotelDetails();
            }
        }

        private void getHotelDetails()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "SELECT * FROM Hotels.Hotel WHERE HotelId = " + Statics.hotelIdTKN;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                hotelNameField.Text = dr.GetString(1);
                contactField.Text = dr.GetString(2);
                emailField.Text = dr.GetString(3);
                webField.Text = dr.GetString(4);
                descriptionFIeld.Text = dr.GetString(5);
                floorCountField.Text = dr.GetSqlInt32(6).ToString();
                capacityField.Text = dr.GetSqlInt32(7).ToString();
                addressField.Text = dr.GetString(8);
                streetField.Text = dr.GetString(9);
                cityField.Text = dr.GetString(10);
                zipField.Text = dr.GetString(11);
                countryField.Text = dr.GetString(12);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DiscountScreen ds = new DiscountScreen();
            ds.Show();
        }

    }
}
