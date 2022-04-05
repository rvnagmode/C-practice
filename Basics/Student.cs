using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Student
    {
        int id;
        String name;
        String location;

        public Student()
        {
            id = 1;
            name = "rushi";
            location = "pune";
        }
        public Student(int i,String nm,String l)
        {
            id = i;
            name = nm;
            location = l;
        }
        public void Display()
        {
            Console.WriteLine("id = "+id+" name = "+name+" location = "+ location);
        }
        public string GetData()
        {
            return "id=" + id + "name=" + name + "location=" + location;
        }

    }
}
