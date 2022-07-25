using System;

namespace M3._16
{
    public class AllMethods
    {
        public static void Method2()
        {
            Console.Write("Base class call to another/Main function ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AllMethods.Method2();
        }
    }
}
