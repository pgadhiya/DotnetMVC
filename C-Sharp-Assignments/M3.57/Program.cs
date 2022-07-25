using System;

namespace M3._57
{
    public class Randomnum
    {
        public int sorted=0, i;
        public int[] ranarr = new int[10];
        Random rnd = new Random();
        public Randomnum()
        {
            Console.WriteLine("Random Number List:");
            for (i = 0; i < 10; i++)
            {
                ranarr[i] = rnd.Next(100);
                Console.WriteLine($"Random no {i}: " + ranarr[i]);
            }
        }
    }
    public class Sortrandom : Randomnum
    {
        public void show()
        {
            
            Array.Sort(ranarr);
            Console.WriteLine("\nSorted List");
            for (int i = 0; i < ranarr.Length; i++)
            {
                Console.WriteLine($"Random no {i}: " + ranarr[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Sortrandom obj1 = new Sortrandom();
            obj1.show();
        }
    }
}
