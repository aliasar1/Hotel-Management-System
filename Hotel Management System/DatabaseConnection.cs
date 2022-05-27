using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class DatabaseConnection
    {
        public DatabaseConnection()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9GED25C;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.ExecuteNonQuery();
            connection.Close();
        }
    }
}
