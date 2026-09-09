using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Strings
{
    internal class CountWord
    {
        static void Main(string[] args)
        {
            // String Task 5 — Count Words in a String

            string str = "I am learning C Sharp language";
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]  == ' ')
                {
                    count++;

                }
            }

            count++;
            Console.WriteLine("The total number of word is :- " + count);

        }
    }
}
