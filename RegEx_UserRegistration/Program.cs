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
            Console.WriteLine(user.validateFirstName("Pankaj"));//True
            Console.WriteLine(user.validateFirstName("pankaj"));//False
            Console.WriteLine(user.validateFirstName("pa"));//False
            //for last name
            Console.WriteLine(user.validateLastName("Th"));//False
            Console.WriteLine(user.validateLastName("thorat"));//False
            Console.WriteLine(user.validateLastName("Thorat"));//True
        }
    }
}
