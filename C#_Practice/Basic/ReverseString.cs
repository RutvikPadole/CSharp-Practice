using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class ReverseString
    {
        // Reverse a string
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string");
            string str = Console.ReadLine();

            string reverse = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str[i];
            }
            Console.WriteLine("Reversed string :- " + reverse);
        }
    }
}
