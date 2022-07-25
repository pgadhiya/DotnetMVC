using System;

namespace M3._37
{
    static class Author
    {
        public static void details()
        {
            Console.WriteLine("Static Class is calling");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Author.details();
        }
    }
}
