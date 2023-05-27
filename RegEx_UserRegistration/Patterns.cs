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
        public static string REGEX_NAME  = "^[A-Z][a-zA-Z]{2,}";
        public static string REGEX_EMAIL = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        public static string REGEX_PHONE = @"^(?:(?:\+|0{0,2})91(\s*[\ -]\s*)?|[0]?)?[789]\d{9}$";
        public static string REGEX_PASS  = @"^(?=.*[A-Z])(?=.*\d)(?=.*\W)(?!.*\W.*\W).{8,}$";
        public bool ValidateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, REGEX_NAME);
        }

        public bool ValidateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, REGEX_NAME); 
        }

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public bool ValidatePhone(string phone)
        {
            return Regex.IsMatch(phone, REGEX_PHONE);
        }
        public bool ValidatePass(string pass)
        {
            return Regex.IsMatch(pass, REGEX_PASS);
        }
    }
}
