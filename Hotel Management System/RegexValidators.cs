using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class RegexValidators
    {

        public String onlyNumbers = "^[0-9]";
        public String onlyAlphabets = "[A-Za-z]";
        public String alphabetsNumbers = "^[a-zA-Z0-9]";
        public String numbersCharacters = "^[\\d*#+]+$";
        public String alphabetsCharacters = "[^0-9]";

    }
}
