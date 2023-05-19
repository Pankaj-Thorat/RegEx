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
        public static string REGEX_Name = "^[A-Z][a-zA-Z]{2,}";
        public bool validateName(string name)
        {
            return Regex.IsMatch(name, REGEX_Name);
        }
    }
}
