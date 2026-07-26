using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Practice
{
    internal class NumberCheck
    {
        static void Main(string[] args)
        {
            // Take a number and check positive / negative

            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                Console.WriteLine("Positive number");
            else
                Console.WriteLine("Negative number");
        }
    }
}
