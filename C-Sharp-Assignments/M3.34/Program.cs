using System;
using System.Collections.Generic;
using System.Linq;

namespace M3._34
{
    class Program
    {
        static void Main(string[] args)
        {
            int j=1,i=1;
            List<int> li = new List<int>();
            Console.Write("Enter a no of list items: ");
            j = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write($"Val {i}: ");
                li.Add(Convert.ToInt32(Console.ReadLine()));                
                i++;
            } while (i <= j);

            Console.WriteLine("List: ");
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
            Console.Write("Total of list items is: "+ li.Sum());
            Console.Read();
        }
    }
}
