using System;

namespace M3._17
{
    class arithmaticcal
    {
        public int a, b, c;
        public arithmaticcal()
        {
            
            Console.Write("Enter value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter value of b: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void displaydata()
        {
            Console.Write("Addition of a and b is: " + (c = a + b));
            Console.WriteLine();
            Console.Write("Substraction of a and b is: " + (c = a - b));
            Console.WriteLine();
            Console.Write("Multiplication of a and b is: " + (c = a * b));
            Console.WriteLine();
            Console.Write("Division of a and b is: " + (c = a / b));
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            arithmaticcal cal = new arithmaticcal();
            cal.displaydata();
        }
    }
}
