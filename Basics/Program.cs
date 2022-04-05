
using Basics;

namespace BasicDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department();
            
            Console.WriteLine(d1.GetData());
            d1.Display();

            Department d2 = new Department(21,"Rishi","Pune");
            d2.Display();
            Console.WriteLine(d2.GetData());

          
        }
    }
}

 
