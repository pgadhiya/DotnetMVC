using System;
using static System.Console;


namespace M3._53
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxnum=0,i;
            Console.Write("Enter array lenth: ");
            string sSize = ReadLine();
            int n = Convert.ToInt32(sSize);
            int[] arr = new int[n];

            for ( i = 0; i < n; i++)
            {
                
                    Console.Write($"Val {i}: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            for (i = 0; i < n; i++)
            {

                if (arr[i] > maxnum)
                {
                    maxnum = arr[i];
                }

            }
            Console.Write("Max value in array is: " + maxnum);
        }
    }
}
