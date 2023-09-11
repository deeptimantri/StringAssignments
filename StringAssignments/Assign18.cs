using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignments
{
     class Assign18
    {
        static void Main(string[] args)
        {
            //string str = "I am an intern at geeksforgeeks";
            //String[] words = str.Split(' ');
            //int length = 0;

            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (length < words[i].Length)
            //    {
            //        length = words[i].Length;
            //    }
            //}
            Console.WriteLine("Enter some string");
            string line = Console.ReadLine();

            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);


        }
    }
}
