using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignments
{
     class Assign6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string");
            string s =Console.ReadLine();

            Console.WriteLine("Enter Character to remove");
            char c = Convert.ToChar(Console.ReadLine());

            int j, count = 0, n = s.Length;
            char[] t = s.ToCharArray();
            for (int i = j = 0; i < n; i++)
            {
                if (s[i] != c)
                    t[j++] = s[i];
                else
                    count++;
            }

            while (count > 0)
            {
                t[j++] = '\0';
                count--;
            }

            Console.Write(t);
        }
    }
}
