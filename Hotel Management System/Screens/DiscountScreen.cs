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
    public partial class DiscountScreen : Form
    {
        DatabaseConnection dc = new DatabaseConnection();
        String query;
        public DiscountScreen()
        {
            InitializeComponent();
            discountIdField.ReadOnly = false;
            checkIfEmployee();
        }

        private void checkIfEmployee()
        {
            if (Statics.employeeIdTKN.Equals(0))
            {

                Console.WriteLine(Statics.employeeIdTKN.Equals(""));
                addButton.Enabled = false;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }


        private void populateTable()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            String query = "SELECT DiscountId AS ID, DiscountName AS Name, DiscountDescription AS Description, DiscountRate AS Rate, EmployeeId AS OfferedBy FROM Bookings.Discount WHERE EmployeeId IN (SELECT EmployeeId FROM Hotels.Employees WHERE HotelId = " + Statics.hotelIdTKN + ");";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            discountTable.DataSource = ds.Tables[0];
            con.Close();
        }

        private void DiscountScreen_Load(object sender, EventArgs e)
        {
            populateTable();
        }

        private void clearFields()
        {
            nameField.Text = "";
            discountIdField.Text = "";
            detailsFIeld.Text = "";
            rateCMBox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (rateCMBox.SelectedIndex != -1 && nameField.Text != "" && detailsFIeld.Text != "")
            {
                query = "INSERT INTO Bookings.Discount  (DiscountName, DiscountDescription, DiscountRate, EmployeeId) VALUES ('" + nameField.Text + "' , '" + detailsFIeld.Text + "', " + rateCMBox.Text + "," + 1 + ")";
                dc.setData(query, "Discount inserted successfully!");
                clearFields();
                populateTable();
            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (discountIdField.Text == "")
            {
                MessageBox.Show("Please enter id to update record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                query = "UPDATE Bookings.Discount SET DiscountName = '" + nameField.Text + "', DiscountDescription = '" + detailsFIeld.Text + "', DiscountRate = " + rateCMBox.Text + ", EmployeeId = " + 1 + " WHERE DiscountId = " + int.Parse(discountIdField.Text);
                dc.setData(query, "Record updated successfully.");
                clearFields();
                populateTable();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (discountIdField.Text == "")
            {
                MessageBox.Show("Please enter id to delete.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                query = "DELETE Bookings.Discount WHERE DiscountId = " + int.Parse(discountIdField.Text);
                dc.setData(query, "Record deleted successfully.");
                clearFields();
                populateTable();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (discountIdField.Text == "")
            {
                MessageBox.Show("Please enter id to search record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                bool temp = false;
                SqlConnection con = dc.getConnection();
                con.Open();
                query = "SELECT * FROM Bookings.Discount WHERE DiscountId = " + discountIdField.Text + "AND EmployeeId IN (SELECT EmployeeId FROM Hotels.Employees WHERE HotelId = " + Statics.hotelIdTKN + ");";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nameField.Text = dr.GetString(1);
                    detailsFIeld.Text = dr.GetString(2);
                    rateCMBox.Text = dr.GetInt32(3).ToString();
                    temp = true;
                }
                if (temp == false)
                    MessageBox.Show("No record found.");
                con.Close();
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void discountTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            discountIdField.Text = discountTable.SelectedRows[0].Cells[0].Value.ToString();
            nameField.Text = discountTable.SelectedRows[0].Cells[1].Value.ToString();
            detailsFIeld.Text = discountTable.SelectedRows[0].Cells[2].Value.ToString();
            rateCMBox.Text = discountTable.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
