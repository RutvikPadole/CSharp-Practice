using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class CountDigit
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            while (num > 0)
            {
                 count++;

                num = num / 10;  
            }

            Console.WriteLine("The number of digit is: " + count);
        }
    }
}

             