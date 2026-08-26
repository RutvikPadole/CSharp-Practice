using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class Fahrenheit
    {
        static void Main()
        {
            // Convert a temperature from Celsius to Fahrenheit (formula: F = C * 9/5 + 32).

            Console.WriteLine("Enter temp in celcius");
            double c = Convert.ToInt32 (Console.ReadLine());

            double F = c * 9 / 5 + 32;
            Console.WriteLine("your result is :" + F);
        }
    }
}
