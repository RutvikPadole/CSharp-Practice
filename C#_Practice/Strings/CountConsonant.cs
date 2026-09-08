using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Strings
{
    internal class CountConsonant
    {
        static void Main(string[] args)
        {
            // String Task 4 — Count Consonants

            string str = "Hello World";

            int count = 0;
            int countconso =0;

            for (int i =0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'i' || str[i] == 'e' || str[i] == 'o' || str[i] == 'u')
                {
                    count++;
                }
                else if (str[i] != ' ')
                {
                    countconso++;
                }

            }

            Console.WriteLine("Vowels :- " + count);
            Console.WriteLine("Consonant :- " + countconso);
        }
    }
}
