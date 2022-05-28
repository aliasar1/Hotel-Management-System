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

        private int id;
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
        private int chainId;
        private String description;
        private String email;
        public HotelsScreen()
        {
            InitializeComponent();
            hotelIdField.ReadOnly = false;
            chainIdField.Enabled = true;
        }

        private void populateTable()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            String query = "SELECT HotelId AS ID, Name, ContactNumber AS Contact, Email, Website, FloorCount AS Floors, TotalRooms AS Rooms, AddressLine AS Address, Street, City, Zip, HotelChainId AS ChainId, Country FROM Hotels.Hotel ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            hotelsTable.DataSource = ds.Tables[0];
            con.Close();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.Show();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            chainIdField.Enabled = false;
            if (hotelIdField.Text == "")
            {
                MessageBox.Show("Please enter id to search record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                bool temp = false;
                SqlConnection con = dc.getConnection();
                con.Open();
                query = "SELECT * FROM Hotels.Hotel WHERE HotelId = " + int.Parse(hotelIdField.Text);
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
                    chainIdField.Text = dr.GetSqlInt32(12).ToString();
                    countryField.Text = dr.GetString(13);
                    temp = true;
                }
                if (temp == false)
                    MessageBox.Show("No record found.");
                con.Close();
            }
        }

        private void HotelsScreen_Load(object sender, EventArgs e)
        {
            populateTable();
            populateHotelChainComboBox();
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
            chainId = int.Parse(chainIdField.Text);
            description = descriptionFIeld.Text;
            email = emailField.Text;
        }

        private void clearFields()
        {
            hotelIdField.Text = "";
            hotelNameField.Text = "";
            contactField.Text = "";
            zipField.Text = "";
            addressField.Text = "";
            cityField.Text = "";
            countryField.Text = "";
            capacityField.Text = "";
            floorCountField.Text = "";
            webField.Text = "";
            streetField.Text = "";
            chainIdField.SelectedIndex = -1;
            descriptionFIeld.Text = "";
            emailField.Text = "";
            addButton.Enabled = true;
            chainIdField.Enabled = true;
        }

        private void populateHotelChainComboBox()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "SELECT HotelChainId from Hotels.HotelChain";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chainIdField.Items.Add(dr["HotelChainId"]);
            }
            con.Close();
        }

        private String getDescription()
        {
            SqlConnection con = dc.getConnection();
            String str = "";
            con.Open();
            query = "SELECT Description from Hotels.Hotel WHERE HotelId = " + int.Parse(hotelIdField.Text);
            SqlCommand cmd = new SqlCommand(query, con);
            str = cmd.ExecuteScalar().ToString();
            con.Close();
            return str;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (hotelIdField.Text != "" || hotelNameField.Text != "" || contactField.Text != "" || zipField.Text != "" || addressField.Text != "" ||
                 cityField.Text != "" || countryField.Text != "" || webField.Text != "" || emailField.Text != "" || capacityField.Text != "" ||
                 floorCountField.Text != "" || streetField.Text != "" || chainIdField.Text != "" || descriptionFIeld.Text != "" || emailField.Text != "")
            {
                getFieldsData();
                query = "INSERT INTO Hotels.Hotel (Name, ContactNumber, Email, Website, Description, FloorCount, TotalRooms, AddressLine, Street, City, Zip, HotelChainId, Country) VALUES ('" + name + "' , '" + contact + "', '" + email + "' , '" + web + "' , '" + description + "' , " + floors + ", " + capacity + ", '" + address + "' , '" + street + "' , '" + city + "' , '" + zip + "' , " + chainId + ", '" + country + "')";
                dc.setData(query, "Hotel inserted successfully!");
                clearFields();
                populateTable();
            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void hotelsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addButton.Enabled = false;
            chainIdField.Enabled = false;
            hotelIdField.Text = hotelsTable.SelectedRows[0].Cells[0].Value.ToString();
            hotelNameField.Text = hotelsTable.SelectedRows[0].Cells[1].Value.ToString();
            contactField.Text = hotelsTable.SelectedRows[0].Cells[2].Value.ToString();
            emailField.Text = hotelsTable.SelectedRows[0].Cells[3].Value.ToString();
            webField.Text = hotelsTable.SelectedRows[0].Cells[4].Value.ToString();
            floorCountField.Text = hotelsTable.SelectedRows[0].Cells[5].Value.ToString();
            capacityField.Text = hotelsTable.SelectedRows[0].Cells[6].Value.ToString();
            addressField.Text = hotelsTable.SelectedRows[0].Cells[7].Value.ToString();
            streetField.Text = hotelsTable.SelectedRows[0].Cells[8].Value.ToString();
            cityField.Text = hotelsTable.SelectedRows[0].Cells[9].Value.ToString();
            zipField.Text = hotelsTable.SelectedRows[0].Cells[10].Value.ToString();
            chainIdField.Text = hotelsTable.SelectedRows[0].Cells[11].Value.ToString();
            countryField.Text = hotelsTable.SelectedRows[0].Cells[12].Value.ToString();
            String str = getDescription();
            descriptionFIeld.Text = str;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            if (hotelIdField.Text == "")
            {
                MessageBox.Show("Please enter id to delete.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                query = "DELETE FROM Hotels.Hotel WHERE HotelId = " + int.Parse(hotelIdField.Text);
                dc.setData(query, "Record deleted successfully.");
                clearFields();
                populateTable();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            if (hotelIdField.Text == "")
            {
                MessageBox.Show("Please enter id to update record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                getFieldsData();
                query = "UPDATE Hotels.Hotel SET Name = '" + name + "', ContactNumber = '" + contact + "', Email= '" + email + "', Website = '" + web + "', Description = '" + description + "', FloorCount = " + floors + ", TotalRooms = " +  capacity + ", AddressLine = '" + address + "', Street = '" + street + "', City = '" + city + "' , Country = '" + country + "', Zip = '" + zip + "' WHERE HotelChainId = " + int.Parse(hotelIdField.Text);
                dc.setData(query, "Record updated successfully.");
                clearFields();
                populateTable();
            }
        }
    }
}
