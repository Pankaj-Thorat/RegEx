using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegEx_UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patterns user = new Patterns();
            //Examples
            //for first name
            Console.WriteLine("For First Name");
            Console.WriteLine(user.validateFirstName("Pankaj"));//True
            Console.WriteLine(user.validateFirstName("pankaj"));//False
            Console.WriteLine(user.validateFirstName("pa"));//False
            //for last name
            Console.WriteLine("For Last Name");
            Console.WriteLine(user.validateLastName("Th"));//False
            Console.WriteLine(user.validateLastName("thorat"));//False
            Console.WriteLine(user.validateLastName("Thorat"));//True
            //for email
            Console.WriteLine("For Email");
            Console.WriteLine(user.validateEmail("abc@bl.co"));//True
            Console.WriteLine(user.validateEmail("abc.xyz@bl.co.in"));//True
            Console.WriteLine(user.validateEmail("Thorat+100@.pl.com"));///False
            //for phone number
            Console.WriteLine("For Phone No.");
            Console.WriteLine(user.validatePhone("9890854276"));   //True
            Console.WriteLine(user.validatePhone("91 9890854276"));//True
            Console.WriteLine(user.validatePhone("+919890854276"));//True
            Console.WriteLine(user.validatePhone("+91989085427")); //False (9 digit)
            //for password rule 2(1upper case)
            Console.WriteLine("For Password");
            Console.WriteLine(user.validatePass("Pankaj123"));    //True
            Console.WriteLine(user.validatePass("pAnkaj@12310")); //True
            Console.WriteLine(user.validatePass("pankaj@12"));    //False
            Console.WriteLine(user.validatePass("PANKAJ@12"));    //True

        }
    }
}
