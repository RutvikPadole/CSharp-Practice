using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class Size
    {
        static void Main()
        {
            // Find the size (in bytes) of int, double, char, bool using sizeof().

            Console.WriteLine("Size of int :" + sizeof(int));
            Console.WriteLine("Size of char :" + sizeof(char));
            Console.WriteLine("Size of double :" + sizeof(double));
            Console.WriteLine("Size of bool :" + sizeof(bool));
        }
    }
}