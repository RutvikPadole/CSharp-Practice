using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class Reverse
    {
        static void Main()
        {
            // WAP to reverse number

            Console.WriteLine("enter numbers");
            int num = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num = num / 10;
            }

            Console.WriteLine("Reversed number : " + reverse);
        }
    }
}
