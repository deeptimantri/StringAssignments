using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignments
{
     class Assign22
    {
        static void Main(string[] args)
        {
            string[] Names = { "Zimbabwe", "South-Africa", "India", "America", "Yugoslavia", " Australia", "Denmark", "France", "Netherlands", "Italy", "Germany"};
            int size = Names.Length;
            //logic for sorting   
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < Names.Length; j++)
                {
                    //compares each elements of the array to all the remaining elements  
                    if (Names[i].CompareTo(Names[j]) > 0)
                    {
                        //swapping array elements  
                        string temp = Names[i];
                        Names[i] = Names[j];
                        Names[j] = temp;
                    }
                }
            }
            for (int i = 0;i< size; i++)
            {
                Console.WriteLine(Names[i]);
            }
        }
    }
}
