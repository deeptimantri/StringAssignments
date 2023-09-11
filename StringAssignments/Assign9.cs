using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignments
{
     class Assign9
    {
        static void Main(string[] args)
        {
            string myStr;
            int i, len, vowel_count, cons_count;
            myStr = "Jack Sparrow";
            vowel_count = 0;
            cons_count = 0;
            // find length
            len = myStr.Length;
            for (i = 0; i < len; i++)
            {
                if (myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u' || myStr[i] == 'A' || myStr[i] == 'E' || myStr[i] == 'I' || myStr[i] == 'O' || myStr[i] == 'U')
                {
                    vowel_count++;
                }
                else if ((myStr[i] >= 'a' && myStr[i] <= 'z') || (myStr[i] >= 'A' &&myStr[i] <= 'Z')) {
                cons_count++;
            }
        }
        Console.Write("Vowel in the string: {0}", vowel_count);
        Console.Write("Consonant in the string: {0}", cons_count);
        }
    }
}
