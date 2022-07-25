using System;

namespace M3._7
{
    class Program
    {

        static void Main(string[] args)
        {
            int a=0,b=0;
            
                Console.Write("Enter Value of a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Value of b: ");
                b = Convert.ToInt32(Console.ReadLine());
           
            if (a > b)
            {
                Console.Write("value of a " + a +" is greater.");
            }
            else
            {
                Console.Write("value of b " + b + " is greater.");
            }
        }
    }
}
