using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class RegexValidators
    {

        public static String onlyNumbers = "^[0-9]+$";
        public static String onlyAlphabets = "[A-Za-z]*";
        public static String alphabetsNumbers = "^[a-zA-Z0-9]";
        public static String numbersCharacters = "^[\\d*#+]+$";
        public static String alphabetsCharacters = "[^0-9]";
        public static String city = @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$";

        public Regex regNums = new Regex(onlyNumbers);
        public Regex regAlpha = new Regex(onlyAlphabets);
    }
}
