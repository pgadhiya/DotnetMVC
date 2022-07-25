using System;
using System.Collections.Generic;
using System.Linq;

namespace M3._61
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> student = new Dictionary<string, string>();
            student.Add("Prakash", "ID-1, .Net MVC");
            student.Add("Piyush", "ID-2, C++");
            student.Add("Yash", "ID-3, Android");
            Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
            foreach (KeyValuePair<string, string> KVP in student)
            {
                Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
            }
        }
    }
}
