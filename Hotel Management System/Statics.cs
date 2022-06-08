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
        public static String employeeNameAndId;
        public static bool newUser;
        public static String uname;
        public static String pass;
        public static int tempEmpId;

        public static void setHotelId(int id)
        {
            hotelIdTKN = id;
        }

        public static void setTempEmplId(int id)
        {
            tempEmpId = id;
        }

        public static void setEmployeeId(int id)
        {
            employeeIdTKN= id;
        }

        public static void hotelNameId(int id, String name)
        {
            hotelNameAndId = name + id;
        }


        public static void EmployeeNameId(int id, String name)
        {
            employeeNameAndId = name + id;
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
