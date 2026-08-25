using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace C__Practice.Basic
{
    internal class AreaOfRectangle
    {
        static void Main(string[] args)
        {
            // Write a program to calculate the area and perimeter of a rectangle given length and width.

            Console.WriteLine("Enter lenght of rectangle");
            double lenght = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter width of rectangle");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = lenght * width;
            double perimeter = 2 *(lenght + width);

            Console.WriteLine("The area of rectangle is : " + area);
            Console.WriteLine("The perimeter of rectangle is : " + perimeter);
        }
    }
}
