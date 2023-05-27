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
            Console.WriteLine(user.ValidateFirstName("Pankaj"));//True
            //Console.WriteLine(user.ValidateFirstName("pankaj"));//False
            //Console.WriteLine(user.ValidateFirstName("pa"));//False
            //for last name
            Console.WriteLine("For Last Name");
            //Console.WriteLine(user.ValidateLastName("Th"));//False
            //Console.WriteLine(user.ValidateLastName("thorat"));//False
            Console.WriteLine(user.ValidateLastName("Thorat"));//True
            //for email
            //Console.WriteLine("For Email");
            //Console.WriteLine(user.ValidateEmail("abc@bl.co"));//True
            //Console.WriteLine(user.ValidateEmail("abc.xyz@bl.co.in"));//True
            //Console.WriteLine(user.ValidateEmail("Thorat+100@.pl.com"));///False
            //for phone number
            Console.WriteLine("For Phone No.");
            Console.WriteLine(user.ValidatePhone("9890854276"));   //True
            Console.WriteLine(user.ValidatePhone("91 9890854276"));//True
            Console.WriteLine(user.ValidatePhone("+919890854276"));//True
            Console.WriteLine(user.ValidatePhone("+91989085427")); //False (9 digit)
            //for password rule 2(1upper case)
            Console.WriteLine("For Password");
            Console.WriteLine(user.ValidatePass("Pankaj123"));    //False
            Console.WriteLine(user.ValidatePass("pAnkaj@"));      //False
            Console.WriteLine(user.ValidatePass("pankaj@12"));    //False
            Console.WriteLine(user.ValidatePass("PANKAJ@12"));    //True
            //for all the valid emails

            Console.WriteLine("For All the valid EMails"); 
            Console.WriteLine(user.ValidateEmail("abc@yahoo.com"));     //True
            Console.WriteLine(user.ValidateEmail("abc-100@yahoo.com")); //True
            Console.WriteLine(user.ValidateEmail("abc.100@yahoo.com")); //True
            Console.WriteLine(user.ValidateEmail("abc111@abc.com"));    //True
            Console.WriteLine(user.ValidateEmail("abc-100@abc.net"));   //True
            Console.WriteLine(user.ValidateEmail("abc.100@abc.com.au"));//True
            Console.WriteLine(user.ValidateEmail("abc@1.com"));         //True
            Console.WriteLine(user.ValidateEmail("abc@gmail.com.com")); //True
            Console.WriteLine(user.ValidateEmail("abc+100@gmail.com")); //True
            
        }
    }
}
