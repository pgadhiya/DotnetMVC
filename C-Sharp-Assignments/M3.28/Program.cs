using System;

namespace M3._28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input third integer:");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, z)));
            Console.WriteLine("Lowest of three: " + Math.Min(x, Math.Min(y, z)));
        }
    }
}
