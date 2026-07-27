using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class LargestNum3
    {
        static void Main(string[] args)
        {
            // WAP to largest of three numbers 

            Console.WriteLine("Enter your first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
                Console.WriteLine("The first number is largest");

            else if (num2 >= num1 && num2 >= num3)
                Console.WriteLine("The second number is largest");

            else
                Console.WriteLine("The third number is largest");


        }
    }
}