using System;


namespace Basics
{
    public class Department
    {
        private int id;
        private string name, location;
        public Department()
        {
            id = 1;
            name = "Admin";
            location = "pune";
        }
        public  Department(int idi,string nm,string loc)
        {
            id = idi;
            name = nm;
            location = loc;
        }
        /* public void AssignData()
         {
             id = 1;
             name = "Admin";
             location="pune;
        }
        */
        public string GetData()
        {
        return "id = "+id+" name = "+name+" location = "+location;
        }
        public void Display()
        {
            Console.WriteLine("id = "+id+ " name = "+name+" location = "+location);
        }
    }
}
