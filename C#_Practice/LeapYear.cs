using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class LeapYear
    {
        static void Main()
        {
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32 (Console.ReadLine());

            if (year % 4 == 0 && (year % 100 !=0 || year % 400 ==0))
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }
        }
    }
}
