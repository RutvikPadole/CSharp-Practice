using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class PalinCheck
    {
        // Check whether a number is palindrome
        static void Main()
        {
            Console.WriteLine("Enter your Palindrome number");
            int num = Convert.ToInt32 (Console.ReadLine());

            int original = num;
            int result = 0;

            while (num > 0)
            {
                int digit = num % 10;
                result = result * 10 + digit;
                num = num / 10;

            }
            if (original == result)

                Console.WriteLine("This is palindrome number");
            else
                Console.WriteLine("This is not palindrome number");
        }
    }
}
