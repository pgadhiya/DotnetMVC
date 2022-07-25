using System;
using System.Collections.Generic;

namespace M3._62
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dObj = new Dictionary<int, string>(5);

            dObj.Add(1, "Tom");
            dObj.Add(2, "John");
            dObj.Add(3, "Maria");
            dObj.Add(4, "Max");
            dObj.Add(5, "Ram");

            for (int i = 1; i <= dObj.Count; i++)
            {
                Console.WriteLine(dObj[i]);
            }
            Console.ReadLine();
        }
    }
}
