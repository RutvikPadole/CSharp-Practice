using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    // Check whether a string is palindrome
    internal class StringPalind
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string");
            string str = Console.ReadLine();

            string reverse = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str[i];

            }
            if (str == reverse)
            
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
    }
}
