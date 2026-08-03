using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Practice
{
    internal class PositiveUsingTernary
    {
        static void Main()
        {
            // Check if a number is positive or negative using ternary.

            Console.WriteLine("Enter your number");
            int num = Convert.ToInt32 (Console.ReadLine());

            string check = num > 0 ? "Positive number" : (num < 0 ? "Negative number" : "Zero");

            Console.WriteLine("The number is : " + check);
        }
    }
}
