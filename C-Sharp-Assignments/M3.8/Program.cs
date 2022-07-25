using System;

namespace M3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b, c = 0, d = 1, e, f;
            Console.WriteLine("Pattern : 1");
            Console.Write("Enter up to no of square: ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < b; i++)
            {
                Console.Write(a * a + " + ");
                a++;
            }
            Console.WriteLine();

            Console.WriteLine("Pattern : 2");
            Console.Write("Enter up to no of series: ");
            f = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < f; i++)
            {
                e = c + d;
                Console.Write(e + " + ");
                c = d;
                d = e;
            }
            Console.WriteLine();



            int sum = 0;
            Console.Write("Enter up to no series: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum = 0;
                for (int j = 1; j <= i; j++)
                {
                    sum += j * j;
                    //Console.Write(j + "^2");
                    //if (j != i)
                    //{
                    //    Console.Write(" + ");
                    //}
                    //else
                    //{
                    //    Console.Write(" = ");
                    //}
                }
                Console.Write(sum + " + ");
                //Console.WriteLine();
            }
        }
    }
}
