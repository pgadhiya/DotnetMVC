using System;

namespace M3._58
{
    public class Counter
    {
        private Counter() { }

        public static int currentCount;

        public static int IncrementCount()
        {
            return ++currentCount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Counter.currentCount = 100;
            Counter.IncrementCount();
            Console.WriteLine("New count: {0}", Counter.currentCount);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
