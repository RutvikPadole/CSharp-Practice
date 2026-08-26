using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.WhileLoop
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            // WAP to check Palindrome numbers

            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int original = num;
            int result = 0;

            while (num > 0)
            {
                int digit = num % 10;
                result = result * 10 + digit;
                num = num / 10;

            }

            if (original == result)
            {
                Console.WriteLine("The number is Palindrome");

            }
            else
            {
                Console.WriteLine("The number is not Palindrome");
            }
        }
    }
}