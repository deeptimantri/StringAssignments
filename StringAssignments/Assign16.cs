using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignments
{
     class Assign16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String 1");
            string a= Console.ReadLine();

            Console.WriteLine("Enter String 2");
            string b= Console.ReadLine();

            int flag = 0;
            char[] charArrayA = a.ToCharArray();
            char[] charArrayB = b.ToCharArray();

            Array.Sort(charArrayA);
            Array.Sort(charArrayB);

            string sortedA = new string(charArrayA);
            string sortedB = new string(charArrayB);

            if (sortedA.Equals(sortedB))
                Console.WriteLine("YES, They are anagrams");
            else
                Console.WriteLine("NO, They are not anagrams");

        }
    }
}
