using C__Practice.Basic;
using C__Practice.WhileLoop;
using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Strings
{
    internal class Palindrom
    {
        static void Main(string[] args)
        {
            // String Task 2 — Check Palindrome

            Console.WriteLine("Enter your string ");
            string str = Console.ReadLine();

            string Reverse = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Reverse = Reverse + str[i];
            }
            
            if (str == Reverse)
            {
                Console.WriteLine("It is palindrome");
            }
            else
            {
                Console.WriteLine("It is not palindrome");
            }
        }
    }
}
