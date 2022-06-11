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
    public partial class CheckoutScreen : Form
    {

        DatabaseConnection dc = new DatabaseConnection();
        String query;

        public CheckoutScreen()
        {
            InitializeComponent();
            paymentIdField.ReadOnly = false;
            checkIfEmployee();
        }

        private void checkIfEmployee()
        {
            if (Statics.employeeIdTKN.Equals(0))
            {
                payButton.Enabled = false;
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            fetchData(0);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard ds = new Dashboard();
            ds.Show();
        }

        private void populateTable()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            String query = "SELECT PaymentId AS ID, PaymentStatus AS Status, PaymentType AS TYPE, PaymentAmount AS Amount, BookingId FROM Bookings.Payments WHERE BookingId IN (SELECT BookingId FROM Bookings.Booking WHERE HotelId = " + Statics.hotelIdTKN + ")";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            checkoutTable.DataSource = ds.Tables[0];
            con.Close();
        }

        private void clearFields()
        {
            paymentIdField.Text = "";
            bookingIdCMBox.Text = "";
            paymentTypeCmbox.Text = "";
            statusField.Text = "";
            amountField.Text = "";
        }

        private void populateBookingIdCmbox()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "SELECT BookingId FROM Bookings.Booking WHERE HotelId = " + Statics.hotelIdTKN;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bookingIdCMBox.Items.Add(dr["BookingId"]);
            }
            con.Close();
        }


        private void CheckoutScreen_Load(object sender, EventArgs e)
        {
            populateTable();
            populateBookingIdCmbox();
        }

        private void bookingIdCMBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(bookingIdCMBox.Text);
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "SELECT BookingAmount From Bookings.Booking WHERE BookingId = " + id;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                amountField.Text = dr.GetSqlInt32(0).ToString();
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (bookingIdCMBox.SelectedIndex != -1 || paymentTypeCmbox.SelectedIndex != -1 || amountField.Text != "")
            {
                int bId = int.Parse(bookingIdCMBox.Text);
                int gId = getGuestIdS(bId);
                query = "UPDATE Hotels.Guests SET Status = 'Not Reserved' WHERE GuestId = " + gId;
                dc.setData(query, "");
                int a = getRoomId(bId);
                query = "UPDATE Rooms.Room SET Available = 'Yes' WHERE RoomId = " + a;
                dc.setData(query, "");
                delServiceUsed(bId);
                query = "INSERT INTO Bookings.Payments VALUES ('" + statusField.Text + "', '" + paymentTypeCmbox.Text + "', " + amountField.Text + ", " + bookingIdCMBox.Text + ")";
                dc.setData(query, "Checkout Data inserted successfully!");
                deleteBooking();
                clearFields();
                populateTable();
            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delServiceUsed(int id)
        {
            query = "DELETE FROM HotelService.ServicesUsed WHERE BookingId = " + id;
            dc.setData(query, "");
        }

        private int getRoomId(int bid)
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "SELECT RoomId from Rooms.RoomBooked WHERE BookingId = " + bid;

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            int id = 0;
            while (dr.Read())
            {
                id = dr.GetInt32(0);
            }
            return id;
        }

        private int getGuestIdS(int bid)
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "SELECT GuestId from Bookings.Booking WHERE BookingId = " + bid;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            int id = 0;
            while (dr.Read())
            {
                id = dr.GetInt32(0);
            }
            return id;
        }

        private void deleteBooking()
        {
            query = "DELETE From Bookings.Booking WHERE BookingId = " + bookingIdCMBox.Text;
            dc.setData(query, "");
        }

        private void checkoutTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fetchData(1);
        }

        private void fetchData(int i)
        {
            String pId;
            if (i == 1)
            {
                pId = checkoutTable.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                pId = paymentIdField.Text;
            }

            Console.WriteLine(pId);

            if (pId == "")
            {
                MessageBox.Show("Please enter id to search record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                bool temp = false;
                SqlConnection con = dc.getConnection();
                con.Open();
                query = "SELECT * FROM Bookings.Payments WHERE PaymentId = " + pId;
                Console.WriteLine(query);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    paymentIdField.Text = dr.GetInt32(0).ToString();
                    statusField.Text = dr.GetString(1);
                    paymentTypeCmbox.Text = dr.GetString(2);
                    amountField.Text = dr.GetInt32(3).ToString();
                    bookingIdCMBox.Text = dr.GetInt32(4).ToString();
                    temp = true;
                }
                if (temp == false && i == 0)
                    MessageBox.Show("No record found.");
                con.Close();
            }
        }
    
    }
}
