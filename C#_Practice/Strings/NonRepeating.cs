using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace C__Practice.Strings
{
    internal class NonRepeating
    {
        static void Main()
        {
            // String Task 9 — Find the First Non-Repeating Character

            string str = "Programming";
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                
                for(int j =0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    Console.WriteLine("First non repeating character is :- " + str[i]);
                    break;
                }

            }
        }
    }
}
