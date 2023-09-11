using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignments
{
    class Class6_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string");
            string word = Console.ReadLine();

            Console.WriteLine("Enter Character to remove");
            char ch =Convert.ToChar(Console.ReadLine());

            StringBuilder s = new StringBuilder(word);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ch)
                {
                    s.Remove(i, 1);
                    i--;
                }
            }
            Console.WriteLine("Original String = "+ word);
            Console.WriteLine("New string ="+ s);

        }

    }
}
