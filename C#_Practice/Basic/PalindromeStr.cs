using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class PalindromeStr
    {
        static void Main()
        {
            string str = "madam";
            string rev = new string (str.Reverse ().ToArray());

            if (str == rev)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not palindrome");
        }

    }
}
