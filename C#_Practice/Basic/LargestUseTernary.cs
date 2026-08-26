using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class LargestUseTernary
    {
        static void Main()
        {
            // Find the larger of two numbers using ternary operator.

            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int largest = num1 >= num2 ? num1 : num2;

            Console.WriteLine("Largest number is : "+ largest);
        }
    }
}
