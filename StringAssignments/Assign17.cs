using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignments
{
     class Assign17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string");
            string str = Console.ReadLine();

            char[] inputArray = str.ToCharArray();
            char[] result = new char[inputArray.Length];

            // Mark spaces in result
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == ' ')
                {
                    result[i] = ' ';
                }
            }

            // Traverse input string from beginning
            // and put characters in result from end
            int j = result.Length - 1;
            for (int i = 0; i < inputArray.Length; i++)
            {

                // Ignore spaces in input string
                if (inputArray[i] != ' ')
                {

                    // ignore spaces in result.
                    if (result[j] == ' ')
                    {
                        j--;
                    }
                    result[j] = inputArray[i];
                    j--;
                }
            }
            for (int i = 0; i < result.Length; i++)
                Console.Write(result[i]);
        }
    }
}
