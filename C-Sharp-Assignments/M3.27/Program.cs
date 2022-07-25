using System;

namespace M3._27
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, userinput, newText;

            Console.Write("Enter String: ");
            text  = Console.ReadLine();

            Console.Write("Which word would you like to remove? ");
            userinput = Console.ReadLine();
            newText = text.Replace(userinput, "");

            Console.WriteLine(newText);
            Console.ReadLine();
        }
    }
}
