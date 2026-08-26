using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class Square
    {
        static void Main()
        {
            Console.WriteLine("Enter one number");
            int num = Convert.ToInt32(Console.ReadLine());

            num = num * num;

            Console.WriteLine("Square is: " + num);
        }
    }
}
