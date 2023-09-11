using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignments
{
     class Assign11
    {
        static void Main(string[] args)
        {
            //int temp;
            //string s = Console.ReadLine();
            //string[] a = s.Split(' ');
            //int k = a.Length - 1;
            //temp = k;
            //for (int i = k; temp >= 0; k--)
            //{
            //    Console.Write(a[temp] + "" + ' ');
            //    --temp;
            //}
            string str = "";
            int i, j, len, startIndex, endIndex;

            Console.WriteLine ("\n Please Enter any String :  ");
            str = Console.ReadLine();

            len =str.Length;
            endIndex = len - 1;

            Console.WriteLine("\n *****  Given String in Reverse Order  ***** \n");
            for (i = len - 1; i >= 0; i--)
            {
                if (str[i] == ' ' || i == 0)
                {
                    if (i == 0)
                    {
                        startIndex = 0;
                    }
                    else
                    {
                        startIndex = i + 1;
                    }
                    for (j = startIndex; j <= endIndex; j++)
                    {
                        Console.Write(str[j]);
                    }
                    endIndex = i - 1;
                    Console.Write(" ");
                }
            }

        }
    }
}
