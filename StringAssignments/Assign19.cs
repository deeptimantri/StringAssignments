using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignments
{
     class Assign19
    {
        static void Main(string[] args)
        {
            String a = "Hello";
            String b = "Geeks";

            // Print String before swapping
            Console.WriteLine("Strings before swap: a =" +
                              " " + a + " and b = " + b);

            // append 2nd string to 1st
            a = a + b;

            // store initial string a in string b
            b = a.Substring(0, a.Length - b.Length);

            // store initial string b in string a
            a = a.Substring(b.Length);

            // print String after swapping
            Console.WriteLine("Strings after swap: a =" +
                              " " + a + " and b = " + b);
        }
    }
}
