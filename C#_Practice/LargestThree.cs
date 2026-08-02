using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace C__Practice
{
    internal class LargestThree
    {
        static void Main()
        {
            //Largest of 3 numbers:

            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("Num1 is largest");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("Num2 is largest");
            }
            else
            {
                Console.WriteLine("Num3 is largest");
            }
        }
    }
}
