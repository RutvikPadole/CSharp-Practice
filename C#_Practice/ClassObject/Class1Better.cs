using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.ClassObject
{
    internal class Class1Better
    {
        string name;
        int age;
        int marks;
        string course;

        public Class1Better()
        {
            this.name = name;
            this.age = age;
            this.marks = marks;
            this.course = course;
        }

        static void Main(string[] args)
        {
            Class1Better obj = new("Rutvik", 22, 92, "MCM");
        }

    }
}
