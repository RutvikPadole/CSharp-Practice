using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Demo
{
    internal class Logic
    {
        static void Main()
        {
            Console.WriteLine("How old are you enter a whole number");

            int age =int.Parse(Console.ReadLine());

            bool IsWithParrent = false;

            if (age >= 18)
            {
                Console.WriteLine("Go party in the club ");
            }
            else if(age >= 13 )
            {
                Console.WriteLine("Are you with your parents");

               String IsWithParrentstring = Console.ReadLine();

                if (IsWithParrentstring == "y")
                {
                    Console.WriteLine("go party in the club with your parents");
                }
                else
                {
                    Console.WriteLine("bhokat jay mg baba le sobt ghevun yeee pahile");
                }
            }


        }
    }
}
