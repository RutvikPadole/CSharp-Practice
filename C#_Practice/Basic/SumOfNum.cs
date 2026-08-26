using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class SumOfNum
    {
        static void Main()
        {

            // Take two numbers and print their sum

            Console.WriteLine("Enter First Number");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Seconde Number");
            int num2 =Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine("Sum is: " + sum);
        }
    }
}
