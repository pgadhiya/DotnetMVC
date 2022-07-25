using System;

namespace M3._54
{
    abstract class Vehicle
    {
        public abstract double Distance { get; set; }
        public abstract double Time { get; set; }
        public abstract double Speed();
    }
    class Car : Vehicle
    {
        double mDistance, mTime = 0.0;
        public override double Distance
        {
            get
            {
                return mDistance;
            }
            set
            {
                if (value <= 0)
                {
                    mDistance = 1;
                }
                else
                {
                    mDistance = value;
                }
            }
        }
        public override double Time
        {
            get
            {
                return mTime;
            }
            set
            {
                if (value <= 0)
                {
                    mTime = 1;
                }
                else
                {
                    mTime = value;
                }
            }
        }
        public override double Speed()
        {
            double speed = 0.0;
            double hours = mTime / 60;
            speed = mDistance / hours;
            return speed;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double speed = 0.0;
            Car objCar = new Car();
            Console.Write("Enter the Distance: ");
            objCar.Distance = Double.Parse(Console.ReadLine());
            Console.Write("Enter the time in minutes: ");
            objCar.Time = Double.Parse(Console.ReadLine());
            speed = objCar.Speed();
            Console.WriteLine("Car speed is {0:0.00}", speed);

            Console.ReadLine();
        }
    }
}
