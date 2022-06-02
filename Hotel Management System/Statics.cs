using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class Statics
    {
        public static int hotelIdTKN;
        public static int employeeIdTKN;

        public static void setHotelId(int id)
        {
            hotelIdTKN = id;
        }

        public static void setEmployeeId(int id)
        {
            employeeIdTKN= id;
        }
    }
}
