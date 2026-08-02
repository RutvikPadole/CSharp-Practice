using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace C__Practice
{
    internal class Switch
    {
        static void Main(string[] args)
        {
            // Take a day number and print only "Weekday" or "Weekend" — using case grouping

            Console.WriteLine("Enter day number (1-7)");
            int day = Convert.ToInt32(Console.ReadLine());

            switch(day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Weekdays");
                    break;

                case 6:
                case 7: 
                    Console.WriteLine("Weekend days");
                    break;

                default:
                    Console.WriteLine("Invalid day number");
                    break;

            }
            
        }
    }
}
