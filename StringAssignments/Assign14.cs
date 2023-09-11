using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringAssignments
{
     class Assign14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the phone number");
            string phno = Console.ReadLine();

            string strRegex = @"^(0|91)?[6-9][0-9]{9}$";
            Regex re = new Regex(strRegex);

            if (re.IsMatch(phno))
                Console.WriteLine("You have entered valid phone number");
            else
                Console.WriteLine("You have not entered valid phone number");
        }
    }
}
