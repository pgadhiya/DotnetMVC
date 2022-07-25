using System;

namespace M3._42
{
    class private_var
    {
        private int i;

        public void display()
        {
            Console.Write("Enter private varable value: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("private varable value: " + i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            private_var p = new private_var();
            p.display();

        }
    }
}
