using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Strings
{
    internal class StringReverse
    {
        static void Main(string[] args)
        {
            // String Task 1 — Reverse a String

            string Name = "Hello";

            for (int i = Name.Length -1; i>=0; i--)
            {
                Console.WriteLine("Reverse string is :- " + Name[i]);
            }

        }
    }
}
