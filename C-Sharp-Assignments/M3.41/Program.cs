using System;

namespace M3._41
{
    class addition
    {
        public void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("addtion of function 1: " + c);
        }
        public void add(int a, int b, int c)
        {
            int d = a + b + c;
            Console.WriteLine("addtion of function 2: " + d);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            addition a = new addition();
            a.add(10, 20);
            a.add(10, 20, 30);

        }
    }
}
