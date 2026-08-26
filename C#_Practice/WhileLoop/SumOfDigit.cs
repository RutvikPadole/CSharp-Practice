using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.WhileLoop
{
    internal class SumOfDigit
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (num > 0)
            {
                int digit = num %10;
                sum = sum + digit;
                num = num /10;
            }
            Console.WriteLine("The sum of digit is: " + sum);
        }
    }
}
