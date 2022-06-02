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
    public partial class ServicesScreen : Form
    {

        DatabaseConnection dc = new DatabaseConnection();
        String query;
        public ServicesScreen()
        {
            InitializeComponent();
            serviceIdField.ReadOnly = false;
        }

        private void populateTable()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            String query = "SELECT ServiceId AS ID, ServiceName AS Name, ServiceDescription AS Description, ServiceCost AS Cost FROM HotelService.Services WHERE HotelId = " + Statics.hotelIdTKN;
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            departmentTable.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ServicesScreen_Load(object sender, EventArgs e)
        {
            populateTable();
        }

        private void clearFields()
        {
            serviceIdField.Text = "";
            serviceNameField.Text = "";
            descriptionField.Text = "";
            costField.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (serviceIdField.Text != "" || serviceNameField.Text != "" || descriptionField.Text != "" || costField.Text != "")
            {
                query = "INSERT INTO HotelService.Services (ServiceName, ServiceDescription, ServiceCost, HotelId) VALUES ('" + serviceNameField.Text + "' , '" + descriptionField.Text + "', " + costField.Text + "," + Statics.hotelIdTKN + ")";
                dc.setData(query, "Services inserted successfully!");
                clearFields();
                populateTable();
            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void departmentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            serviceIdField.Text = departmentTable.SelectedRows[0].Cells[0].Value.ToString();
            serviceNameField.Text = departmentTable.SelectedRows[0].Cells[1].Value.ToString();
            descriptionField.Text = departmentTable.SelectedRows[0].Cells[2].Value.ToString();
            costField.Text = departmentTable.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (serviceIdField.Text == "")
            {
                MessageBox.Show("Please enter id to update record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                query = "UPDATE HotelService.Services SET ServiceName = '" + serviceNameField.Text + "', ServiceDescription = '" + descriptionField.Text + "', ServiceCost = " + costField.Text + " WHERE ServiceId = " + int.Parse(serviceIdField.Text);
                dc.setData(query, "Record updated successfully.");
                clearFields();
                populateTable();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (serviceIdField.Text == "")
            {
                MessageBox.Show("Please enter id to delete.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                query = "DELETE HotelService.Services WHERE ServiceId = " + int.Parse(serviceIdField.Text);
                dc.setData(query, "Record deleted successfully.");
                clearFields();
                populateTable();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (serviceIdField.Text == "")
            {
                MessageBox.Show("Please enter id to search record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                bool temp = false;
                SqlConnection con = dc.getConnection();
                con.Open();
                query = "SELECT * FROM HotelService.Services WHERE ServiceId = " + int.Parse(serviceIdField.Text);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    serviceNameField.Text = dr.GetString(1);
                    descriptionField.Text = dr.GetString(2);
                    costField.Text = dr.GetInt32(3).ToString();
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
    }
}
