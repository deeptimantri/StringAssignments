using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringAssignments
{
     class Assign20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter email address");
            string email = Console.ReadLine();
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                Console.WriteLine("Email address is valid");
            else
                Console.WriteLine("Email address is not valid");
        }
    }
}

