using System;

namespace M3._55
{
    public abstract class MyClass
    {
        public abstract void calculate(double x);
    }
    class Sub1 : MyClass
    {
        public override void calculate(double x)
        {
            Console.WriteLine("SQUARE ROOT IS " + Math.Sqrt(x));
        }
    }
    public class Sub2 : MyClass
    {
        public override void calculate(double x)
        {
            Console.WriteLine("SQUARE is :" + (x * x));
        }
    }
    public class Sub3 : MyClass
    {
        public override void calculate(double x)
        {
            Console.WriteLine("CUBE is :" + (x * x * x));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter value of x: ");
            x = Convert.ToInt32(Console.ReadLine());

            Sub1 obj1 = new Sub1();
            Sub2 obj2 = new Sub2();
            Sub3 obj3 = new Sub3();
            obj1.calculate(x);
            obj2.calculate(x);
            obj3.calculate(x);
            Console.ReadLine();
        }
    }
}
