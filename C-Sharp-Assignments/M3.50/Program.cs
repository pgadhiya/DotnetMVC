using System;
using static System.Console;

namespace M3._50
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.Write("Enter array lenth: ");
            string sSize = ReadLine();
            int n = Convert.ToInt32(sSize);            
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    Console.Write($"Val {j}: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }
    }
}
