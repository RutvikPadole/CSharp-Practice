using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Demo
{
    internal class Rocket
    {
        static void Main(string[] args)
        {

            string rocket = @"

                     /\
                    /  \
                   |====|
                   |    |
                  /|.  .|\
                 / |.__.| \
                    |  |
                   /    \
                  /      \
                 /        \        
                /__________\
                 V  V  V  V
";

            for (int Counter = 10; Counter >=0; Counter--)
            {
                Console.Clear();
                Console.WriteLine("Counter is " + Counter);
                Console.WriteLine(rocket);
                rocket = "\r\n" + rocket;
                Thread.Sleep(1000);
            }
            Console.WriteLine("Rocket Has Landed !");

            Console.ReadKey();
        }
       
    }
}
