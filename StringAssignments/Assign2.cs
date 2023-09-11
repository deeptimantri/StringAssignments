using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignments
{
     class Assign2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string");
            string str= Console.ReadLine();

            for (int i=0;i <str.Length;i++)
            {
               char ch = str[i];
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == ch)
                    {
                        Console.WriteLine($"{str[j]} occurs at {j} index");
                        break;
                    }
                }
            }
        }
       
      }
    }
