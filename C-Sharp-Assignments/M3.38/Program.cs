using System;

namespace M3._38
{
    public class Firstname
    {
        public void fname() { Console.WriteLine("Prakash "); }
    }
    public class Lastname : Firstname
    {
        public void lname() { Console.WriteLine("Gadhiya "); }
    }
    public class Age : Lastname
    {
        public void hage() { Console.WriteLine(32); }
    }
    public class Datails : Age
    {
        public void display() { Console.WriteLine("Details:"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Datails obj1 = new Datails();
            obj1.display();
            obj1.fname();
            obj1.lname();
            obj1.hage();
        }
    }
}
