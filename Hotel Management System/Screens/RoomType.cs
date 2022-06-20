using Hotel_Management_System.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.Screens
{
    public partial class RoomType : Form
    {
        DatabaseConnection dc = new DatabaseConnection();
        String query;

        public RoomType()
        {
            InitializeComponent();
            typeIdField.ReadOnly = false;
        }

        private void populateTable()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            String query = "SELECT RoomTypeId AS ID, Name, Cost, SmokeFriendly, PetFriendly FROM Rooms.RoomType WHERE HotelId = " + Statics.hotelIdTKN;
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            roomtypeTable.DataSource = ds.Tables[0];
            con.Close();
        }

        private void RoomType_Load(object sender, EventArgs e)
        {
            populateTable();
        }

        private void clearFields()
        {
            typeIdField.Text = "";
            typeNameField.Text = "";
            costField.Text = "";
            petCMBox.SelectedIndex = -1;
            smokeCMBox.SelectedIndex = -1;
        }

        private bool regChecker()
        {
            if (!Regex.Match(typeNameField.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("City field must contain alpabets or space only.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                typeNameField.Focus();
                return false;
            }
            if (!Regex.Match(costField.Text, @"^[0-9]+$").Success)
            {
                MessageBox.Show("Contact number must only contain numbers.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                costField.Focus();
                return false;
            }
            return true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (typeNameField.Text != "" && costField.Text != "" && smokeCMBox.SelectedIndex != -1 && petCMBox.SelectedIndex != -1)
            {
                bool regCheck = regChecker();
                if (regCheck == false)
                {
                    return;
                }
                query = "INSERT INTO Rooms.RoomType (Name, Cost, SmokeFriendly, PetFriendly, HotelId) VALUES ('" + typeNameField.Text + "' , " + costField.Text + ", '" + smokeCMBox.Text + "', '" + petCMBox.Text + "', " + Statics.hotelIdTKN + ")";
                Console.WriteLine(query);
                dc.setData(query, "RoomType inserted successfully!");
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
            addButton.Enabled = true;
            clearFields();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            if (typeIdField.Text == "")
            {
                MessageBox.Show("Please enter id to update record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                bool regCheck = regChecker();
                if (regCheck == false)
                {
                    return;
                }
                query = "UPDATE Rooms.RoomType SET Name = '" + typeNameField.Text + "', Cost = " + costField.Text + ", PetFriendly = '" + petCMBox.Text + "', SmokeFriendly = '" + smokeCMBox.Text + "' WHERE RoomTypeId = " + int.Parse(typeIdField.Text);
                dc.setData(query, "Record updated successfully.");
                clearFields();
                populateTable();
            }
        }

        private void departmentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addButton.Enabled = false;
            typeIdField.Text = roomtypeTable.SelectedRows[0].Cells[0].Value.ToString();
            typeNameField.Text = roomtypeTable.SelectedRows[0].Cells[1].Value.ToString();
            costField.Text = roomtypeTable.SelectedRows[0].Cells[2].Value.ToString();
            smokeCMBox.Text = roomtypeTable.SelectedRows[0].Cells[3].Value.ToString();
            petCMBox.Text = roomtypeTable.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            if (typeIdField.Text == "")
            {
                MessageBox.Show("Please enter id to delete.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                query = "DELETE FROM Rooms.RoomType WHERE RoomTypeId = " + int.Parse(typeIdField.Text);
                dc.setData(query, "Record deleted successfully.");
                clearFields();
                populateTable();
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            RoomsScreen rs = new RoomsScreen();
            rs.populate(); 
            this.Hide();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            if (typeIdField.Text == "")
            {
                MessageBox.Show("Please enter id to search record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                bool temp = false;
                SqlConnection con = dc.getConnection();
                con.Open();
                query = "SELECT * FROM Rooms.RoomType WHERE RoomTypeId = " + int.Parse(typeIdField.Text) + " AND HotelId = " + Statics.hotelIdTKN;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    typeNameField.Text = dr.GetString(1);
                    costField.Text = dr.GetInt32(2).ToString();
                    smokeCMBox.Text = dr.GetString(3);
                    petCMBox.Text = dr.GetString(3);
                    temp = true;
                }
                if (temp == false)
                    MessageBox.Show("No record found.");
                con.Close();
            }
        }
    }
}
