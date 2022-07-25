using System;

namespace M3._59
{
    class Program
    {
        public class Person
        {
            public string _name;
            public int _age;
            public string _sex;
            public Person(string name, int age, string sex)
            {
                this._age = age;
                this._sex = sex;
                this._name = name;
            }

            public void Age()
            {
                Console.WriteLine($"Person :: Hi, I am {this._age} years old!");
            }
            public virtual void Introduction()
            {
                Console.WriteLine($"Person :: Hi, my name is {this._name}, I am {this._age} years old and I am a {this._sex}");
            }
        }

        public class Men : Person
        {
            public Men(string name, int age) : base(name, age, "male")
            {
            }
            public void Age()
            {
                Console.WriteLine($"Men :: Hi, I am {this._age} years old!");
            }
            public override void Introduction()
            {
                Console.WriteLine($"Men :: Hi, my name is {this._name}, I am {this._age} years old and I am a {this._sex}");
            }
        }
        static void Main(string[] args)
        {
            Men Dani = new Men("Szabó Dániel Ernő", 28);
            Person Alien = Dani;
            Dani.Introduction();
            Alien.Introduction();
            Dani.Age();
            Alien.Age();
            Console.ReadKey();
        }
    }
}
