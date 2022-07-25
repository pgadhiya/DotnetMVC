using System;

namespace M3._21
{
    public class Class1
    {
        public void display()
        {
            Console.WriteLine("Super class display method");
        }
    }
    public class Class2 : Class1
    {
        public void display1()
        {
            Console.WriteLine("Sub class display method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.display();
            Console.ReadLine();
        }
    }
}
