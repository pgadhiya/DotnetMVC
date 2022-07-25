using System;

namespace M3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World! This is world of string functions";

            string c = "HelloWorld";
            string d = "World";

            string e = "Hello";
            string f = string.Copy(e);

            string g = "Hello";
            int h = g.IndexOf('o');

            string i = "Hello";
            string j = i.Substring(2);

            Console.WriteLine("Concat Function");
            Console.WriteLine(string.Concat(a, b));
            Console.WriteLine();

            Console.WriteLine("Contains Function");
            Console.WriteLine(c.Contains(d));
            Console.WriteLine();

            Console.WriteLine("Copy Function");
            Console.WriteLine(f);
            Console.WriteLine();

            Console.WriteLine("IndexOf Function");
            Console.WriteLine(h);
            Console.WriteLine();

            Console.WriteLine("SubString Function");
            Console.WriteLine(j);
            Console.WriteLine();
        }
    }
}
