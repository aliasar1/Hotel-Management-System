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
            String query = "SELECT PaymentId AS ID, PaymentStatus AS Status, PaymentType AS TYPE, PaymentAmount AS Amount, BookingId FROM Bookings.Payments WHERE BookingId IN (SELECT BookingId FROM Bookings.Booking WHERE HotelId = " + 4 + ")";
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
            statusPaid.Text = "";
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
            if (bookingIdCMBox.SelectedIndex != -1 || paymentTypeCmbox.SelectedIndex != -1 || amountField.Text != "" || statusPaid.SelectedIndex != -1)
            {
                query = "INSERT INTO Bookings.Payments VALUES ('" + statusPaid.Text + "', '" + paymentTypeCmbox.Text + "', " + amountField.Text + ", " + bookingIdCMBox.Text + ")";
                dc.setData(query, "Checkout Data inserted successfully!");
                clearFields();
                populateTable();
            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                    statusPaid.Text = dr.GetString(1);
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
