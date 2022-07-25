using System;

namespace C_Sharp_Assignments
{
     //3. Create program to take 5 students details using structure
    class Program
    {
        int i, j,n=1;
        int[,] s_rollno = new int[100, 100];
        readonly double[,] Percent = new double[100, 100];
        string[,] s_name = new string[50,50];

        public Program(){
            Console.Write("Enter no of Students: ", n);
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    Console.Write("Students " + i +" Roll No: ");
                    s_rollno[i,j] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: ");
                    s_name[i, j] = Console.ReadLine();
                    Console.Write("Percentage: ");
                    Percent[i, j] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                }
            }
        }
        public void showData()
        {
            Console.WriteLine("Student details: ");
            for (i = 1; i <= n; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    Console.Write(i + ". ");
                    Console.Write(s_rollno[i, j] + " ");
                    Console.Write(s_name[i, j] + " ");
                    Console.Write(Percent[i, j] + " ");
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            Program s = new Program();
            s.showData();
            //Console.WriteLine("Hello World!");
        }
    }
}
