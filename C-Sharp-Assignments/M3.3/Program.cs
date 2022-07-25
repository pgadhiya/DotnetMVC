using System;

namespace M3._3
{
    class Program
    {
        int n, i;
        int[] S_rollno = new int[50];
        string[] S_name = new string[50];
        int[] S_marks = new int[50];
        public Program()
        {
            
            Console.WriteLine("Enter no of students: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {

                Console.WriteLine("Enter Student " + i + " Details: ");
                Console.Write("Roll no: ");
                S_rollno[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name: ");
                S_name[i] = Console.ReadLine();
                Console.Write("Marks: ");
                S_marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void ShowData()
        {
            Console.WriteLine("Student Details:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Student " + i + " Details: ");
                Console.WriteLine("Roll No Is: " + S_rollno[i]);
                Console.WriteLine("Name Is: " + S_name[i]);
                Console.WriteLine("Marks Is: " + S_marks[i]);
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {


            Program p = new Program();
            p.ShowData();
            Console.ReadLine();
        }
    }
}
