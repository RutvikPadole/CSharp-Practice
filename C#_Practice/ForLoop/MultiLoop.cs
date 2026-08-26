using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.ForLoop
{
    internal class MultiLoop
    {
        // Print the multiplication table of a number entered by the user
        // (e.g., if user enters 5, print 5×1=5, 5×2=10, ... up to 5×10=50).
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + "X" + i +" = " + (num * i));
            }
        }
    }
}
