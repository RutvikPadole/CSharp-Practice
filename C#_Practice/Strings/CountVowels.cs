using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Strings
{
    internal class CountVowels
    {
        static void Main(string[] args)
        {
            // String Task 3 — Count Vowels

            string str = "Hello World";

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine("Vowels :- " + count);

        }
    
 } }

