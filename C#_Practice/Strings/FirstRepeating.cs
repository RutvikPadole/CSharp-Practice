using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Strings
{
    internal class FirstRepeating
    {
        static void Main(string[] args)
        {
            // String Task 10 — Find the First Repeating Character

            string str = "Programming";

            for (int i =0; i < str.Length; i++)
            {
                for (int j = i+1; j < str.Length; j++)
                {
                   if (str[i] == str[j])
                    {
                        Console.WriteLine("First repeating character is :- " + str[i]);
                    }
                    break;
                }
                
            }
        }
    }
}
