using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class ReverseStr
    {
        // // Reverse a string using reverse word
        static void Main()
        {   
            string str = "Hello";
            char[] arr = str.ToCharArray();
            System.Array.Reverse(arr);
            string result = new string(arr);

            Console.WriteLine(result);

        }
    }
}
