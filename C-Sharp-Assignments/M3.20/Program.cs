using System;

namespace M3._20
{
    class factorial
    {
        
        public void fact()
        {
            int i, number, fact;
            Console.Write("Enter the Number: ");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine($"Factorial of {number} is: " + fact);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            factorial fac = new factorial();
            fac.fact();
            Console.ReadLine();
        }
    }
}
