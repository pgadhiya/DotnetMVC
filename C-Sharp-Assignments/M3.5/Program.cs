using System;

namespace M3._5
{
    class Program
    {
        //5. Create program to sort string in descending order
        static void descOrder(char[] s)
        {
            Array.Sort(s);
            reverse(s);
        }
        static void reverse(char[] a)
        {
            int i, n = a.Length;
            char t;
            for (i = 0; i < n / 2; i++)
            {
                t = a[i];
                a[i] = a[n - i - 1];
                a[n - i - 1] = t;
            }
        }

        static void Main(string[] args)
        {
            char[] s = "Prakash".ToCharArray();
            descOrder(s);
            Console.WriteLine(String.Join("", s));
        }
    }
}
