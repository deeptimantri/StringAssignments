using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignments
{
    class Assign8
    {
        static void Main(string[] args)
        {
            char[] str = "geeksforgeeks".ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                    str[i] = (char)(str[i] + 'a' - 'A');
                else if (str[i] >= 'a' && str[i] <= 'z')
                    str[i] = (char)(str[i] + 'A' - 'a');
            }
            Console.WriteLine("String after toggle ");
            Console.WriteLine(String.Join("", str));
        }
    }
}
