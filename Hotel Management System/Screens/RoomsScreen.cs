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
    public partial class RoomsScreen : Form
    {

        DatabaseConnection dc = new DatabaseConnection();
        String query;

        int roomId;

        public RoomsScreen()
        {
            InitializeComponent();
            roomIdField.ReadOnly = false;
            costField.ReadOnly = true;
        }

        private void populateTable()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            String query = "SELECT * FROM Rooms.Room WHERE HotelId = " + Statics.hotelIdTKN;
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            roomsTable.DataSource = ds.Tables[0];
            con.Close();
        }

        public void populate()
        {
            populateTable();
            populateTypeComboBox();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            if (roomIdField.Text == "")
            {
                MessageBox.Show("Please enter id to search record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                bool temp = false;
                SqlConnection con = dc.getConnection();
                con.Open();
                query = "SELECT * FROM Rooms.Room WHERE RoomId = " + int.Parse(roomIdField.Text);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    roomNoField.Text = dr.GetInt32(1).ToString();
                    typeCmbox.Text = getNameFromId(dr.GetInt32(3));
                    findCost();
                    temp = true;
                }
                if (temp == false)
                    MessageBox.Show("No record found.");
                con.Close();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            clearFields();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            RoomType rt = new RoomType();
            rt.Show();
        }

        private void clearFields()
        {
            roomIdField.Text = "";
            roomNoField.Text = "";
            typeCmbox.SelectedIndex = -1;
            costField.Text = "";
        }

        private void populateTypeComboBox()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "SELECT Name from Rooms.RoomType";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                typeCmbox.Items.Add(dr["Name"]);
            }
            con.Close();
        }

        private int getIdFromTypeName()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "SELECT RoomTypeId from Rooms.RoomType WHERE Name = '" + typeCmbox.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                roomId = dr.GetInt32(0);
            }
            return roomId;
        }

        String name;

        private String getNameFromId(int id)
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "SELECT Name from Rooms.RoomType WHERE RoomTypeId = " + id + "";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                name = dr.GetString(0);
            }
            return name;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int id = getIdFromTypeName();
            if (roomIdField.Text != "" || roomNoField.Text != "" || typeCmbox.Text != "" || costField.Text != "")
            {
                query = "INSERT INTO Rooms.Room (RoomNumber, HotelId, RoomTypeId) VALUES (" + roomNoField.Text + ", " + Statics.hotelIdTKN + ", " + id + ")";
                dc.setData(query, "Room inserted successfully!");
                clearFields();
                populateTable();
            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void typeCmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            findCost();
        }

        private void findCost()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            int cost = 0; ;
            query = "SELECT Cost from Rooms.RoomType WHERE Name = '" + typeCmbox.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cost = dr.GetInt32(0);
            }
            costField.Text = cost.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            if (roomIdField.Text == "")
            {
                MessageBox.Show("Please enter id to update record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                getIdFromTypeName();
                query = "UPDATE Rooms.Room SET RoomNumber = " + roomNoField.Text + ", RoomTypeId = " + roomId + " WHERE RoomId = " + int.Parse(roomIdField.Text);
                dc.setData(query, "Record updated successfully.");
                clearFields();
                populateTable();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            if (roomIdField.Text == "")
            {
                MessageBox.Show("Please enter id to delete.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                query = "DELETE FROM Rooms.Room WHERE RoomId = " + int.Parse(roomIdField.Text);
                dc.setData(query, "Record deleted successfully.");
                clearFields();
                populateTable();
            }
        }

        private void RoomsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addButton.Enabled = false;
            roomIdField.Text = roomsTable.SelectedRows[0].Cells[0].Value.ToString();
            roomNoField.Text = roomsTable.SelectedRows[0].Cells[1].Value.ToString();
            typeCmbox.SelectedItem = getNameFromId(int.Parse(roomsTable.SelectedRows[0].Cells[2].Value.ToString()));
            findCost();
        }
    }
}
