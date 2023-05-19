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
            Console.WriteLine(user.validateName("Pa"));
        }
    }
}
