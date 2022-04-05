using System;
using Basics;

namespace Basics
{
    internal class StudOutput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("using default constructor");
            Student s = new Student();
            s.Display();
            Console.WriteLine(s.GetData());
            Console.WriteLine();
            Console.WriteLine("using parameterised constructor");
            Student s1 = new Student(1,"sai","nashik ");
            s1.Display();
            Console.WriteLine(s1.GetData());
        }
    }
}
