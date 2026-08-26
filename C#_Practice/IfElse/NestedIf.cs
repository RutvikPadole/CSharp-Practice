using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.IfElse
{
    internal class NestedIf
    {
        static void Main()
        {
            // Login system:

            Console.WriteLine("Enter username");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password");
           string password = Console.ReadLine();

            if (username == "admin")
            {
                if (password == "1234")
                {
                    Console.WriteLine("Login Successfull");
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }
    }
}
