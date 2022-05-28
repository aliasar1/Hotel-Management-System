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
    public partial class HotelChainPage : Form
    {

        String query;
        DatabaseConnection dc = new DatabaseConnection();
        private Int64 currentId = 0;
        private String name;
        private String num;
        private String address;
        private String city;
        private String country;
        private String zip;
        private String email1;
        private String street;
        private String website;

        public HotelChainPage()
        {
            InitializeComponent();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperAdminLogin superAdmin = new SuperAdminLogin();
            superAdmin.Show();
        }


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            if (hotelChainIdField.Text == "")
            {
                MessageBox.Show("Please enter id to search record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                bool temp = false;
                SqlConnection con = dc.getConnection();
                con.Open();
                query = "SELECT * FROM Hotels.HotelChain WHERE HotelChainId = " + int.Parse(hotelChainIdField.Text);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chainNameField.Text = dr.GetString(1);
                    contactNumField.Text = dr.GetString(2);
                    emailField.Text = dr.GetString(3);
                    websiteField.Text = dr.GetString(4);
                    addressField.Text = dr.GetString(5);
                    streetField.Text = dr.GetString(6);
                    cityField.Text = dr.GetString(7);
                    zipField.Text = dr.GetString(8);
                    countryField.Text = dr.GetString(9);
                    temp = true;
                }
                if (temp == false)
                    MessageBox.Show("No record found.");
                con.Close();
            }
        }

        private void populateTable()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            String query = "SELECT HotelChainId AS ID, HotelName AS Name, ContactNumber AS Contact, Email, Website, AddressLine AS Address, Street, City, Zip, Country FROM Hotels.HotelChain ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            hotelsChainTable.DataSource = ds.Tables[0];
            con.Close();
        }

        private void generateId()
        {
            try
            {
                String query = "SELECT MAX(HotelChainId) FROM Hotels.HotelChain";
                DataSet ds = dc.getData(query);

                if (ds.Tables[0].Rows[0][0].ToString() != "")
                {
                    currentId = (Int64.Parse(ds.Tables[0].Rows[0][0].ToString()));
                    hotelChainIdField.Text = (currentId + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void getFieldsData()
        {
            name = chainNameField.Text;
            num = contactNumField.Text;
            address = addressField.Text;
            city = cityField.Text;
            country = countryField.Text;
            zip = zipField.Text;
            email1 = emailField.Text;
            street = streetField.Text;
            website = websiteField.Text;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(hotelChainIdField.Text != "" || chainNameField.Text != "" || contactNumField.Text != "" || zipField.Text != "" || addressField.Text != "" ||
                 cityField.Text != "" || countryField.Text != "" || websiteField.Text != "" ||emailField.Text != "")
            {
                getFieldsData();

                query = "INSERT INTO Hotels.HotelChain (HotelName, ContactNumber, Email, Website, AddressLine, Street, City, Country, Zip) VALUES ('" + name + "' , '" + num + "', '" + email + "' , '" + website + "' , '" + address + "' , '" + street + "' , '" + city + "' , '" + zip + "' , '" + country + "')";
                dc.setData(query, "Hotel chain inserted!");
                clearFields();
                populateTable();
            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearFields()
        {
            hotelChainIdField.Text = "";
            chainNameField.Text = "";
            contactNumField.Text = "";
            addressField.Text = "";
            cityField.Text = "";
            countryField.Text = "";
            zipField.Text = "";
            emailField.Text = "";
            streetField.Text = "";
            websiteField.Text = "";
        }

        private void HotelChainPage_Load(object sender, EventArgs e)
        {
            populateTable();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            clearFields();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            if (hotelChainIdField.Text == "")
            {
                MessageBox.Show("Please enter id to delete.", "Missing Info" ,MessageBoxButtons.OK);
            }
            else
            {
                query = "DELETE FROM Hotels.HotelChain WHERE HotelChainId = " + int.Parse(hotelChainIdField.Text);
                dc.setData(query, "Record deleted successfully.");
                clearFields();
                populateTable();
            }
        }

        private void hotelsChainTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addButton.Enabled = true;
            hotelChainIdField.Text = hotelsChainTable.SelectedRows[0].Cells[0].Value.ToString();
            chainNameField.Text = hotelsChainTable.SelectedRows[0].Cells[1].Value.ToString();
            contactNumField.Text = hotelsChainTable.SelectedRows[0].Cells[2].Value.ToString();
            emailField.Text = hotelsChainTable.SelectedRows[0].Cells[3].Value.ToString();
            websiteField.Text = hotelsChainTable.SelectedRows[0].Cells[4].Value.ToString();
            addressField.Text = hotelsChainTable.SelectedRows[0].Cells[5].Value.ToString();
            streetField.Text = hotelsChainTable.SelectedRows[0].Cells[6].Value.ToString();
            cityField.Text = hotelsChainTable.SelectedRows[0].Cells[7].Value.ToString();
            zipField.Text = hotelsChainTable.SelectedRows[0].Cells[8].Value.ToString();
            countryField.Text = hotelsChainTable.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            if (hotelChainIdField.Text == "")
            {
                MessageBox.Show("Please enter id to update record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                getFieldsData();
                query = "UPDATE Hotels.HotelChain SET HotelName = '" + name + "', ContactNumber = '" + num + "', Email= '" + email1 + "', Website = '" + website + "', AddressLine = '" + address + "', Street = '" +  street + "', City = '" + city + "' , Country = '" + country + "', Zip = '" + zip + "' WHERE HotelChainId = " + int.Parse(hotelChainIdField.Text);
                dc.setData(query, "Record updated successfully.");
                clearFields();
                populateTable();
            }
        }
    }
}
