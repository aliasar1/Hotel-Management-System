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
    public partial class GuestsScreen : Form
    {

        DatabaseConnection dc = new DatabaseConnection();
        String query;

        private int id;
        private String fname;
        private String lname;
        private String contact;
        private String email;
        private String cnic;
        private String passNum;
        private String city;
        private String zip;
        private String street;
        private String address;

        public GuestsScreen()
        {
            InitializeComponent();
            guestIdField.ReadOnly = false;
        }

        private void populateTable()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            String query = "SELECT GuestId AS ID, GuestFirstName AS FName, GuestLastName AS LName, GuestEmailAddress AS Email, GuestContactNumber AS Contact, AddressLine AS Address, City, Zip FROM Hotels.Guests WHERE HotelId = " + Statics.hotelIdTKN;
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guestTable.DataSource = ds.Tables[0];
            con.Close();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.Show();
        }

        private void clearFields()
        {
            guestIdField.Text = "";
            fnameField.Text = "";
            lnameField.Text = "";
            emailField.Text = "";
            numberField.Text = "";
            passportField.Text = "";
            cnicField.Text = "";
            addressField.Text = "";
            streetField.Text = "";
            cityField.Text = "";
            zipField.Text = "";
        }

        private void GuestsScreen_Load(object sender, EventArgs e)
        {
            populateTable();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(guestIdField.Text);
            retrieveData(id);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (guestIdField.Text != "" && fnameField.Text != "" && lnameField.Text != "" && emailField.Text != "" && numberField.Text != "" && passportField.Text != "" && zipField.Text != ""
                || addressField.Text != "" && cityField.Text != "" && streetField.Text != "")
            {
                String cnic = cnicField.Text == "" ? "NULL" : cnicField.Text;
                String passNum = passportField.Text == "" ? "NULL" : passportField.Text;
                query = "INSERT INTO Hotels.Guests (GuestFirstName, GuestLastName, GuestEmailAddress, GuestContactNumber, GuestPassportNumber, AddressLine, Street, City, Zip, GuestCnic, HotelId) VALUES ('" + fnameField.Text + "' , '" + lnameField.Text + "', '" + emailField.Text + "', '" + numberField.Text + "', '" + passNum + "', '" + addressField.Text + "', '" + streetField.Text + "', '" + cityField.Text + "', '" + zipField.Text + "', '" + cnic + "', " + Statics.hotelIdTKN + ")";
                dc.setData(query, "Guest inserted successfully!");
                clearFields();
                populateTable();
            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void retrieveData(int id)
        {
            if (guestIdField.Text == "")
            {
                MessageBox.Show("Please enter id to search record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                bool temp = false;
                SqlConnection con = dc.getConnection();
                con.Open();
                query = "SELECT * FROM Hotels.Guests WHERE GuestId = " + id + "AND HotelId = " +Statics.hotelIdTKN;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                this.id = id;
                while (dr.Read())
                {
                    fname = dr.GetString(1);
                    fnameField.Text = fname;
                    lname = dr.GetString(2);
                    lnameField.Text = lname;
                    email = dr.GetString(3);
                    emailField.Text = email;
                    contact = dr.GetString(4);
                    numberField.Text = contact;
                    passNum = dr.GetString(5);
                    passportField.Text = passNum;
                    cnic = dr.IsDBNull(6) ? "NULL" : dr.GetString(6); 
                    cnicField.Text = cnic;
                    address = dr.IsDBNull(7) ? "NULL" : dr.GetString(7);
                    addressField.Text = address;
                    street = dr.GetString(8);
                    streetField.Text = street;
                    city = dr.GetString(9);
                    cityField.Text = city;
                    zip = dr.GetString(10);
                    zipField.Text = zip;
                    temp = true;
                }
                if (temp == false)
                    MessageBox.Show("No record found.");
                con.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (guestIdField.Text == "")
            {
                MessageBox.Show("Please enter id to delete.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                query = "DELETE FROM Hotels.Guests WHERE GuestId = " + int.Parse(guestIdField.Text);
                dc.setData(query, "Record deleted successfully.");
                clearFields();
                populateTable();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (guestIdField.Text == "")
            {
                MessageBox.Show("Please enter id to update record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                query = "UPDATE Hotels.Guests SET GuestFirstName = '" + fnameField.Text + "', GuestLastName = '" + lnameField.Text + "', GuestEmailAddress = '" + emailField.Text + "', GuestContactNumber = '" + numberField.Text + "', GuestCnic = '" + cnicField.Text + "', GuestPassportNumber = '" + passportField.Text + "', AddressLine = '" + addressField.Text + "', Street = '" + streetField.Text + "', City = '" + cityField.Text + "', Zip = '" + zipField.Text + "' WHERE GuestId = " + int.Parse(guestIdField.Text);
                dc.setData(query, "Record updated successfully.");
                clearFields();
                populateTable();
            }
        }

        private void guestTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guestIdField.Text = guestTable.SelectedRows[0].Cells[0].Value.ToString();
            retrieveData(int.Parse(guestIdField.Text));
        }
    }
}
