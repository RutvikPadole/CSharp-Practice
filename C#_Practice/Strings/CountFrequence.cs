using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Strings
{
    internal class CountFrequence
    {
        static void Main(string[] args)
        {
            // String Task 6 — Count Frequency of a Character "G"

            string str = "Programming";
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'g')
                {
                    count++;
                }
            }

            Console.WriteLine("The Frequency of g is :- " + count);
        }
    }
}
