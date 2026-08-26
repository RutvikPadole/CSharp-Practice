using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Switch
{
    internal class SwithGrade
    {
        static void Main()
        {
            //Grading system using switch:

            Console.WriteLine("Enter your grade");
            char grade = Convert.ToChar(Console.ReadLine());

            switch(grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Good");
                    break;
                case 'C':
                    Console.WriteLine("Average");
                        break;
                case 'D':
                    Console.WriteLine("Below Average");
                    break;
                case 'E':
                    Console.WriteLine("Fail");
                    break;

                default:
                    Console.WriteLine("Wrong input");
                    break;

            }
        }
    }
}
