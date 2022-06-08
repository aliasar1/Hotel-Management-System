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
        public static String hotelNameAndId;
        public static bool newUser;
        public static String uname;
        public static String pass;

        public static void setHotelId(int id)
        {
            hotelIdTKN = id;
        }

        public static void setEmployeeId(int id)
        {
            employeeIdTKN= id;
        }

        public static void hotelNameId(int id, String name)
        {
            hotelNameAndId = name + id;
        }

        public static void isNewUser(bool str)
        {
            newUser = str;
        }

        public static void setUname(String str)
        {
            uname = str;
        }

        public static void setPass(String str)
        {
            pass = str;
        }
    }
}
