using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class Palindrome2
    {
        static void Main()
        {
            // Practice Questions

            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32 (Console.ReadLine());

            int original = num;
            int reverse = 0;

            while ( num > 0)
            {
                int digit = num % 10; 
                reverse = reverse * 10 + digit;
                num = num / 10;

            }
            if (original == reverse)

                Console.WriteLine("The number is palindrome");
            else
                Console.WriteLine("The number is not palindrome");
        }
    }
}
