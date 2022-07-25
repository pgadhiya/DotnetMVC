using System;

namespace M3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, a = 1, n;
            Console.Write("Enter Number of row: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pattern: 1 ");
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" " + a);
                    a++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Enter Number of row: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pattern: 2 ");
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    for (j = 1; j <= i; j++)
                    {

                        Console.Write(" # ");

                    }
                }
                else
                {
                    for (j = 1; j <= i; j++)
                    {

                        Console.Write(" * ");

                    }
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.Write("Enter Number of row: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pattern: 3 ");
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if(j % 2 == 0)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write(" # ");
                    }
                }
                Console.WriteLine();
            }

            Console.Write("Enter Number of row: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pattern: 4 ");
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }

            Console.Write("Enter Number of row: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pattern: 5 ");
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.Write("Enter Number of row: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pattern: 6 ");
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
           
            Console.ReadLine();
        }
    }
}
