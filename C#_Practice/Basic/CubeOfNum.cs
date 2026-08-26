using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class CubeOfNum
    {
        static void Main(string[] args)
        {

            // Cube of number

            Console.WriteLine("enter one number");
            int num=Convert.ToInt32(Console.ReadLine());

            int cube = num * num * num;

            Console.WriteLine("Cube is: " + cube);
        }
    }
}
