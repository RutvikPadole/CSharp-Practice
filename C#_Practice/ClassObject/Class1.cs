using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace C__Practice.ClassObject
{
    internal class Class1
    {
        String name;
        int age;
        int marks;
        string course;
    
    static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class1 c2 = new Class1();
            c1.name = "Rutvik";
            c1.marks = 92;
            c1.age = 22;
            c1.course = "MCM";

            c2.name = "Satish";
            c2.marks = 98;
            c2.age = 29;
            c2.course = "MCM";


            Console.WriteLine(c1.name);
            Console.WriteLine(c1.marks);
            Console.WriteLine(c1.age);
            Console.WriteLine(c1.course);

            Console.WriteLine(c2.name);
            Console.WriteLine(c2.marks);
            Console.WriteLine(c2.age);
            Console.WriteLine(c2.course);
        }
    }
}
