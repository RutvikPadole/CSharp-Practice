using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class NumReverse
    {
        static void Main()
        {
            //Write a C# program to reverse a number.

            Console.WriteLine("Enter your number");
            int num = Convert.ToInt32 (Console.ReadLine());

            int reverse = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num = num / 10;

            }
            Console.WriteLine("Reverse number is : " + reverse);
        }
    }
}
