using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class LeapYearUsingTernary
    {
        static void Main(string[] args)
        {
            //Rewrite your leap year checker's final if-else
            //(Leap year / Not a leap year) using a ternary operator instead.

            Console.WriteLine("Enter Year");
            int Year = Convert.ToInt32(Console.ReadLine());

            string Check = (Year % 4 == 0 && (Year % 100 != 0 || Year % 400 == 0)) ? "Leap year" : "Not leap year";

            Console.WriteLine(Check);
        }
    }
}
