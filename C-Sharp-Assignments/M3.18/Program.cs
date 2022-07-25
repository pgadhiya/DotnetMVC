using System;

namespace M3._18
{
    class Parent
    {
        public void Display()
        {
            Console.WriteLine("This is parent class");
        }
    }
    class Child : Parent
    {
        public void Display1()
        {
            Console.WriteLine("This is child class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child obj1 = new Child();
            obj1.Display();
        }
    }
}
