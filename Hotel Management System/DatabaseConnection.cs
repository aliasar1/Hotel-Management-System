using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    internal class DatabaseConnection
    {
        public SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9GED25C;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            return connection;
        }

        public DataSet getData(String query)
        {
            SqlConnection connection = getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            connection.Close();
            return ds;
        }

        public void setData(String query, String message)
        {
            SqlConnection connection = getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("'" + message + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
