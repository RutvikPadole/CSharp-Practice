using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class LinqOrderBy
    {
        static void Main()
        {
            string[] names = { "Ravi", "Anita", "Kiran", "Meena" };

            var sortAsd = names.OrderBy(n => n);

            Console.WriteLine("Alphabetical order");

            foreach ( var name in sortAsd )
            {
                Console.WriteLine(name);
            }

            var sortDesc = names .OrderByDescending(n => n);

            Console.WriteLine("\n Reverse order");

            foreach( var name in sortDesc )
            {
                Console.WriteLine(name);
            }                 

        }
    }
}
