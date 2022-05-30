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
            costField.ReadOnly = true;
        }

        private void populateTable()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            String query = "SELECT * FROM Rooms.Room";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            roomTable.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            populateTable();
            populateTypeComboBox();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
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
    }
}
