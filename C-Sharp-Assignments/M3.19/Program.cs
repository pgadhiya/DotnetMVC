using System;

namespace M3._19
{
    class  studentdata
    {
        int i,j,n;
        int[,] marks = new int[50,50];
        string[] sname = new string[50];
        int[] total = new int[50];
        int[] avg = new int[50];
        public void GetData()
        {
            Console.Write($"Enter no of student: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (i = 1; i <= n; i++)
            {
                Console.Write($"Student {i} name: ");
                sname[i] = Console.ReadLine();
                for (j = 1; j <= 3; j++)
                {
                    Console.Write($"Sub {j}: ");
                    marks[i,j] = Convert.ToInt32(Console.ReadLine());
                    total[i] += marks[i, j];
                }
                avg[i] = (total[i] / 3);


            }
            
        }
        public void DisplayData()
        {
            Console.Write("SR. ");
            Console.Write("Name ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Sub {i} ");
            }
            Console.Write("Total ");
            Console.Write("Avg ");
            Console.WriteLine();
            for (i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
                Console.Write(sname[i] + " ");
                for (j = 1; j <= 3; j++)
                {
                    Console.Write(marks[i,j] + " ");                    
                }
                Console.Write(total[i] + " ");
                Console.Write(avg[i] + " ");
                Console.WriteLine();

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            studentdata obj = new studentdata();
            obj.GetData();
            obj.DisplayData();

            Console.ReadLine();
        }
    }
}
