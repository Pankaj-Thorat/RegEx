using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx_UserRegistration
{
    class Patterns
    {
        public static string REGEX_NAME = "^[A-Z][a-zA-Z]{2,}";
        public bool validateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, REGEX_NAME);
        }

        public bool validateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, REGEX_NAME); 
        }
    }
}
