using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Strings
{
    internal class FindDuplicate
    {
        static void Main(string[] args)
        {
            //String Task 7 — Find Duplicate Characters

            string str = "Programming";

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i+1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        Console.WriteLine("Duplicate Character is :- " + str[i]);
                        break;
                    }

                }
            }
        }
    }
}
