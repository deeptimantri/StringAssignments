using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignments
{
     class Assign4
    {
        static void Main(string[] args)
        {
            
                string str = "          geeksforgeeks";
                char[] str1 = new char[100] ;

                int idx = 0, j, k = 0;
                while (str[idx] == ' ' || str[idx] == '\t' || str[idx] == '\n')
                {
                    idx++;
                }
                for (j = idx; j<str.Length; j++)
                {
                    str1[k] = str[j];
                    k++;
                }
            Console.WriteLine("Original string ="+ str);

            Console.Write("New String is =");
            for (int i = 0; i <str1.Length; i++)
            {
                Console.Write(str1[i]);        
            }


        }
    }
}
