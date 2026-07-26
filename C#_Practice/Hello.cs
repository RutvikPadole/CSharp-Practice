using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace C__Practice
{
    internal class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter one number");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num*num);
        }
    }
}
